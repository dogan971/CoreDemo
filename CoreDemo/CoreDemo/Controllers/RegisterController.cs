using BusinessLayer.Concreate;
using BusinessLayer.Validationrules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            List<SelectListItem> countries = new List<SelectListItem>
            {
                 new SelectListItem
                 {
                     Text = "Şehir Seçiniz"
                 },
                new SelectListItem
                 {
                     Text = "Ankara",
                     Value = 1.ToString()
                 },
                new SelectListItem
                 {
                     Text = "İstanbul",
                     Value = 2.ToString()
                 },
                new SelectListItem
                 {
                     Text = "İzmir",
                     Value = 3.ToString()
                 },
                new SelectListItem
                 {
                     Text = "Eskişehir",
                     Value = 4.ToString()
                 },
                new SelectListItem
                 {
                     Text = "Antalya",
                     Value = 5.ToString()
                 },
                new SelectListItem
                 {
                     Text = "Bodrum",
                     Value = 6.ToString()
                 }
            }.ToList();
            ViewBag.item = countries;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult validation = wv.Validate(p);
            if (validation.IsValid)
            {
                p.writerStatus = true;
                p.writerAbout = "test";
                wm.Add(p);
                wm.addWriter(p);
                return RedirectToAction("Index", "Blog");
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



    }
}
