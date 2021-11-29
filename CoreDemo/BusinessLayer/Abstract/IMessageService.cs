using EntityLayer.Concreate;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message2>
    {

        List<Message2> GetInboxListByWriter(int id);
        



    }
}
