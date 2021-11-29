using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concreate
{
    public class AboutManager : IAboutService
    {
        IAboutDal _AboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _AboutDal = aboutDal;
        }

        public void Add(About p)
        {
            throw new NotImplementedException();
        }

        public void Delete(About p)
        {
            throw new NotImplementedException();
        }

        public About getById(int id)
        {
            throw new NotImplementedException();
        }



        public List<About> List()
        {
            return _AboutDal.getList();
        }

        public void Update(About p)
        {
            throw new NotImplementedException();
        }
    }
}
