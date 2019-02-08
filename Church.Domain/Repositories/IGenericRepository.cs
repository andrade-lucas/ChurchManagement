using System.Collections.Generic;

namespace Church.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Create(T entity);
        void Edit(T entity);
        T FindById(string id);
        List<T> GetAll();
        void Delete(string id);
    }
}
