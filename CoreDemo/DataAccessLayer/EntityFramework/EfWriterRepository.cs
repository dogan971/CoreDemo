using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;

namespace DataAccessLayer.EntityFramework
{
    public class EFWriterRepository : GenericRepository<Writer>, IWriterDal
    {
     
    }
}
