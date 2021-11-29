using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T p);
        void Delete(T p);
        void Update(T p);
        List<T> List();
        T getById(int id);
    }
}
