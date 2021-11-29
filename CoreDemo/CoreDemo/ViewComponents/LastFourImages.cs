using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents
{
    [ViewComponent]
    public class LastFourImages : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {

            var values = bm.getListWithCategory().TakeLast(4).ToList();
            return View(values);


        }


    }
}
