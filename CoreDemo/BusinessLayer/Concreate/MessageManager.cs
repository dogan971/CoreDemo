using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concreate
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messagedal;
        public MessageManager(IMessageDal messageDal)
        {
            _messagedal = messageDal;
        }
        public void Add(Message2 p)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message2 p)
        {
            throw new NotImplementedException();
        }

        public Message2 getById(int id)
        {
            return _messagedal.getByID(id);
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messagedal.getListWithMessageByWriter(id);
        }

        public List<Message2> List()
        {
            return _messagedal.getList();
        }

        public void Update(Message2 p)
        {
            throw new NotImplementedException();
        }


    }
}
