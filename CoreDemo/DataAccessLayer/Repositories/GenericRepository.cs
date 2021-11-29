using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories
{

    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        context c = new context();
        public void Delete(T p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public T getByID(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> getList()
        {
            return c.Set<T>().ToList();
        }

        public T getListWithFilter(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().FirstOrDefault(filter);
        }

        public void Insert(T p)
        {
            c.Add(p);
            c.SaveChanges();
        }

        public List<T> ListID(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.Update(p);
            c.SaveChanges();
        }



    }
}
