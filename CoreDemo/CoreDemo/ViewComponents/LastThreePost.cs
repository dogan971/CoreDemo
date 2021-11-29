using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    [AllowAnonymous]
    [ViewComponent]
    public class LastThreePost : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.getLastThreeBlog();
            return View(values);
        }

    }
}
