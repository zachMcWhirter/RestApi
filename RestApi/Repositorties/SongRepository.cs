using Microsoft.EntityFrameworkCore;
using RestApi.Data;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Repositorties
{
    public class SongRepository : ISongRepository
    {
        private readonly ApiDbContext _dbContext;

        // Constructor
        public SongRepository(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ApiDbContext DbContext { get; }

        public bool Create(Song entity)
        {
            _dbContext.Songs.Add(entity);
            return Save();
        }

        public bool Delete(Song entity)
        {
            _dbContext.Songs.Remove(entity);
            return Save();
        }

        public ICollection<Song> GetAll()
        {
            var Songs = _dbContext.Songs.ToList();
            return Songs;
        }

        public Song GetById(int id)
        {
            var Song = _dbContext.Songs.Find(id);
            return Song;
        }

        public bool IsExistingId(int id)
        {
            // Any() is looking for any id that matched the id of the queried item
            var exists = _dbContext.Songs.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _dbContext.SaveChanges();
            return changes > 0;
        }

        public bool Update(Song entity)
        {
            _dbContext.Songs.Update(entity);
            return Save();

        }
    }
}
