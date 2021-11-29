using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IWriterService : IGenericService<Writer>
    {

        List<Writer> GetWriterbyID(int id);
        Writer writerFilter(Expression<Func<Writer, bool>> filter);

    }
}
