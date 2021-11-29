using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Writer p)
        {
            context c = new context();
            var datavalue = c.writers.FirstOrDefault(x => x.writerMail == p.writerMail && x.writerPassword == p.writerPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.writerMail)
                };

                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Dashboard");
            }
            else return View();
        }

        //        context c = new context();
        //        // tek değer üzerinde sorgu ve işlem için firstordefault
        //        var datavalue = c.writers.FirstOrDefault(x => x.writerMail == p.writerMail && x.writerPassword == p.writerPassword);
        //            if (datavalue != null)
        //            {
        //                // key -> username 
        //                HttpContext.Session.SetString("username", p.writerMail);
        //                return RedirectToAction("Index", "Blog");
        //    }
        //            else
        //            {
        //                return View();
        //}













    }
}
