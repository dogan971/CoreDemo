using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        [AllowAnonymous]
        public IActionResult AllNotifications()
        {
            var values = nm.List();
            return View(values);
        }
    }
}
