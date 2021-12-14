using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    [ViewComponent]
    public class WidgetStatistic2 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.List().OrderByDescending(x => x.blogID).Select(x => x.blogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}
