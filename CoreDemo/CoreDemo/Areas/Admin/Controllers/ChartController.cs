using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> categories = new List<CategoryClass>();
            categories.Add(new CategoryClass
            {
                CategoryName = "Teknoloji",
                CategoryCount = 10
            } 
            );
            categories.Add(new CategoryClass
            {
                CategoryName = "Yazılım",
                CategoryCount = 20
            }
          );
            categories.Add(new CategoryClass
            {
                CategoryName = "Bilişim",
                CategoryCount = 50
            }
          );

            // Json formatında çağırcağımız için 
            // bir isim veriyoruz önce
            return Json(new { jsonList=categories });
        }

    }
}
