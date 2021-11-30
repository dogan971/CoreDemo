using BusinessLayer.Concreate;
using BusinessLayer.Validationrules;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
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
            CategoryValidator cv = new CategoryValidator();
            ValidationResult validation = cv.Validate(p);
            if (validation.IsValid)
            {
                p.categoryStatus = true;
                cm.Add(p);
                return RedirectToAction("CategoryList", "Category");
            }
            else {
                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View(); }
          
        }


        public IActionResult CategoryDelete(int id)
        {
            var value = cm.getById(id);
            cm.Delete(value);
            return RedirectToAction("CategoryList");
        }
       
    }
}
