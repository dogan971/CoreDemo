using EntityLayer.Concreate;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal : IGenericDal<Message2>
    {
        List<Message2> getListWithMessageByWriter(int id);
    }
}
