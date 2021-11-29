using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents
{
    [ViewComponent]
    public class BlogListDashboard : ViewComponent
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());
        WriterManager wm = new WriterManager(new EFWriterRepository());
        public IViewComponentResult Invoke()
        {
            
            var values = bm.getListWithCategory().TakeLast(10).OrderByDescending(x => x.blogID).ToList();
            return View(values);


        }

    }
}
