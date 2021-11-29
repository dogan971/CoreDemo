using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;

namespace BusinessLayer.Concreate
{

    public class ContactManager : IContactService
    {
        IContactDal _contactdal;
        public ContactManager(IContactDal ıcontactDal)
        {
            _contactdal = ıcontactDal;
        }
        public void Add(Contact contact)
        {
            _contactdal.Insert(contact);
        }
    }
}
