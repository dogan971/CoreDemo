using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{

    [AllowAnonymous]
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        WriterManager wm = new WriterManager(new EFWriterRepository());
        context c = new context();
        public IActionResult Index()
        {

            ViewBag.v1 = c.blogs.Count().ToString();
            var userMail = User.Identity.Name;
            var id = wm.writerFilter(x => x.writerMail == userMail).writerID;
            ViewBag.v2 = c.blogs.Where(x => x.writerID == id).Count();
            ViewBag.v3 = c.categories.Count();
         
            return View();
        }


    }
}
