using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        // Area için bir attribute oluşturuyoruz
        //[Route("Admin/[Controller]/[Action]/{id?}")]

        [Route("Admin/[Controller]/[Action]/{id?}")]
        public IActionResult CategoryList(int page = 1)
        {
            
            var values = cm.List().ToPagedList(page,3);
            return View(values);
        }
 
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            p.categoryStatus = true;
            cm.Add(p);
            return View();
        }
       
    }
}
