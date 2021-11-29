using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {

        [AllowAnonymous]
        public IActionResult Index()
        {
            MessageManager mm = new MessageManager(new EfMessageRepository());
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult Details()
        {
            MessageManager mm = new MessageManager(new EfMessageRepository());
            int id = 2;
            var values = mm.getById(id);
            return View(values);
        }
    }
}
