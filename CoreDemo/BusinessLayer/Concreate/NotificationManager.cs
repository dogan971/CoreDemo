using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concreate
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationdal;
        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationdal = notificationDal;
        }
        public void Add(Notification p)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notification p)
        {
            throw new NotImplementedException();
        }

        public Notification getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> List()
        {
            return _notificationdal.getList();
        }

        public void Update(Notification p)
        {
            throw new NotImplementedException();
        }
    }
}
