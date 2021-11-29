
using BusinessLayer.Concreate;
using BusinessLayer.Validationrules;
using CoreDemo.Models;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace CoreDemo.Controllers
{

    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());


        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult menuPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        
        [HttpGet]
        public IActionResult WriterEditProfile()
        {

            var userMail = User.Identity.Name;
            var id = wm.writerFilter(x => x.writerMail == userMail).writerID;
            var values = wm.getById(id);
            return View(values);
        }
        
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult validation = wv.Validate(p);
            if (validation.IsValid)
            {
                p.writerStatus = true;
                wm.Update(p);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }


        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {

            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.writerImage != null)
            {
                var extension = Path.GetExtension(p.writerImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.writerImage.CopyTo(stream);
                w.writerImage = newImageName;

            }
            w.writerName = p.writerName;
            w.writerMail = p.writerMail;
            w.writerAbout = p.writerAbout;
            w.writerPassword = p.writerPassword;
            w.writerStatus = true;
            wm.Add(w);
            return RedirectToAction("Index", "Dashboard");
        }

    }
}
