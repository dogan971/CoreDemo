using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageRepository : GenericRepository<Message2>, IMessageDal
    { 

        public List<Message2> getListWithMessageByWriter(int id)
        {
            using (var c = new context()) 
            {
                return c.messages2.Include(x => x.Sender).Where(x => x.SenderID == id).ToList();
            }
        }
    }
}
