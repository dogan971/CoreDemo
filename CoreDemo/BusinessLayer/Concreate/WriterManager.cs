using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concreate
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writer;
        public WriterManager(IWriterDal writerdal)
        {
            _writer = writerdal;
        }

        public void Add(Writer p)
        {
            _writer.Insert(p);
        }



        public void Delete(Writer p)
        {
            throw new NotImplementedException();
        }

        public Writer getById(int id)
        {
            return _writer.getByID(id);
        }

        public List<Writer> GetWriterbyID(int id)
        {
            return _writer.ListID(x => x.writerID == id);
        }

        public List<Writer> List()
        {
            return _writer.getList();
        }

        public void Update(Writer p)
        {
            _writer.Update(p);
        }
        public void addWriter(Writer p)
        {

            _writer.Insert(p);
        }

        public List<Writer> getListAll()
        {
            return _writer.getList();
        }
 
        public Writer writerFilter(Expression<Func<Writer, bool>> filter)
        {
            return _writer.getListWithFilter(filter);
        }
    }
}
