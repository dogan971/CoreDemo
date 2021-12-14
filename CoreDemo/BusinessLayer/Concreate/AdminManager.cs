using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class AdminManager : IAdminService
    {
        IAdminDal _admindal;
        public AdminManager(IAdminDal adminDal)
        {
            _admindal = adminDal;
        }
        public void Add(Admin p)
        {
            throw new NotImplementedException();
        }

        public void Delete(Admin p)
        {
            throw new NotImplementedException();
        }

        public Admin getById(int id)
        {
            return _admindal.getByID(id);
        }

        public List<Admin> List()
        {
            return _admindal.getList();
        }

        public void Update(Admin p)
        {
            throw new NotImplementedException();
        }
    }
}
