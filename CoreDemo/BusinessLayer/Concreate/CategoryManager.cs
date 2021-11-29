using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System.Collections.Generic;

namespace BusinessLayer.Concreate
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void Add(Category p)
        {
            _categorydal.Insert(p);
        }

        public void Delete(Category p)
        {
            _categorydal.Delete(p);
        }

        public Category getById(int id)
        {
            return _categorydal.getByID(id);
        }

        public List<Category> List()
        {
            return _categorydal.getList();
        }

        public void Update(Category p)
        {
            _categorydal.Update(p);
        }
    }
}
