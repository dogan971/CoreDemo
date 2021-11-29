using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    [ViewComponent]
    public class WriterNotification : ViewComponent
    {

        NotificationManager nm = new NotificationManager(new EfNotificationRepository());

        public IViewComponentResult Invoke()
        {

            var values = nm.List();
            return View(values);


        }



    }
}
