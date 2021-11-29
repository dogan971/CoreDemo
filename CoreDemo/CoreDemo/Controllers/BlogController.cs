using BusinessLayer.Concreate;
using BusinessLayer.Validationrules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        WriterManager wm = new WriterManager(new EFWriterRepository());
        public IActionResult Index()
        {

            var values = bm.getListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.i = id;
            var values = bm.getBlogById(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var userMail = User.Identity.Name;
            var id = wm.writerFilter(x => x.writerMail == userMail).writerID;
            var values = bm.getListCategoryByWriter(id);
            return View(values);
        }


        [HttpGet]
        public IActionResult AddBlog()
        {
            function();
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog p)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult validation = bv.Validate(p);
            var userMail = User.Identity.Name;
            var id = wm.writerFilter(x => x.writerMail == userMail).writerID;
            if (validation.IsValid)
            {
                p.blogStatus = true;
                p.blogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.writerID = id;
                bm.Add(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                function();
                return View();
            }

        }



        public IActionResult DeleteBlog(int id)
        {

            var value = bm.getById(id);
            bm.Delete(value);
            return RedirectToAction("BlogListByWriter", "Blog");



        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog p)
        {
            var userMail = User.Identity.Name;
            var id = wm.writerFilter(x => x.writerMail == userMail).writerID;
            p.blogStatus = true;
            p.blogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.writerID = id;
            bm.Update(p);
            return RedirectToAction("BlogListByWriter", "Blog");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            function();
            var value = bm.getById(id);

            return View(value);
        }


        public void function()
        {

            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> dgr1 = (from x in cm.List().ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.categoryName,
                                             Value = x.categoryID.ToString()



                                         }).ToList();
            ViewBag.val1 = dgr1;
        }

    }
}
