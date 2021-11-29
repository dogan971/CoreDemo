using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.contactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.contactStatus = true;
            cm.Add(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}
