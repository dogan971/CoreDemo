using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            string city = "ankara";
            string api = "78ccfb0562ff52e37ee6b174f74724ce";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&lang=tr&units=metric&appid=" + api;
            // Uri verdik 
            XDocument document = XDocument.Load(connection);
            // Descendants kısmında çekmek istediğimiz etiketi  yazıyoruz
            // Attribute da da onun içinde olan hangi veriyi alıcağımız yani 
            // <temperature value="11.77" min="11.68" max="12.81" unit="celsius"/>
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.v5 = document.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            ViewBag.v6 = document.Descendants("feels_like").ElementAt(0).Attribute("unit").Value;
            ViewBag.city = city;
            return View();
        }

    }
}
