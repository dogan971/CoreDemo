using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    [ViewComponent]
    public class  WidgetStatistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        context c = new context();
        public IViewComponentResult Invoke()
        {

            ViewBag.v1 = bm.List().Count();
            ViewBag.v2 = c.contacts.Count();
            ViewBag.v3 = c.comments.Count();
            return View();
        }

    }
}
