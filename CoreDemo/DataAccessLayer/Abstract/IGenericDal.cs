using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        T getByID(int id);
        List<T> getList();


        T getListWithFilter(Expression<Func<T, bool>> filter);
        List<T> ListID(Expression<Func<T, bool>> filter);

    }
}
