using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> getListWithCategory()
        {
            using (var c = new context())
            {
                return c.blogs.Include(x => x.category).ToList();
            }
        }

        public List<Blog> getListWithCategoryByWriter(int id)
        {
            using (var c = new context())
            {
                return c.blogs.Include(x => x.category).Where(x => x.writerID == id).ToList();
            }
        }
    }
}
