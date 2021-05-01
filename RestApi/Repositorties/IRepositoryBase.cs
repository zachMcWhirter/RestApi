using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Repositorties
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> GetAll();

        bool IsExistingId(int id);
        T GetById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
