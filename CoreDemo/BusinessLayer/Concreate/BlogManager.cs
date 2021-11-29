using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concreate
{

    public class BlogManager : IBlogService
    {
        IBlogDal _blogdal;
        public BlogManager(IBlogDal blogdal)
        {
            _blogdal = blogdal;
        }
        public void Add(Blog p)
        {
            _blogdal.Insert(p);
        }

        public void Delete(Blog p)
        {
            _blogdal.Delete(p);
        }

        public Blog getById(int id)
        {
            return _blogdal.getByID(id);
        }

        public List<Blog> getBlogById(int id)
        {
            return _blogdal.ListID(x => x.blogID == id);
        }

        public List<Blog> getLastThreeBlog()
        {
            return _blogdal.getList().Take(3).ToList();
        }


        public List<Blog> getListWithCategory()
        {
            return _blogdal.getListWithCategory();
        }

        public void Update(Blog p)
        {
            _blogdal.Update(p);
        }

        public List<Blog> getBlogListWithWriter(int id)
        {
            return _blogdal.ListID(x => x.writerID == id);
        }

        public List<Blog> List()
        {
            return _blogdal.getList();
        }

        public List<Blog> getListCategoryByWriter(int id)
        {
            return _blogdal.getListWithCategoryByWriter(id);
        }
    }
}
