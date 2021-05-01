using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
    // DbContext is the base class
    public class ApiDbContext : DbContext
    {
        // base(options) will be the base calss constructor
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        {

        }
        // This constuctor will create a table in the db called Songs (at runtime)
        public DbSet<Song> Songs { get; set; }
    }
}
