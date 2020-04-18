using System.Collections.Generic;

namespace hw_12
{
    public interface IRepository<T>
    {
        void Create(T obj);
        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Update(int id);
        void Delete(int id);
    }
}
