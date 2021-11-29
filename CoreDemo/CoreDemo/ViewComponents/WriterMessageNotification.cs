using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.ViewComponents
{
    [AllowAnonymous]
    [ViewComponent]
    public class WriterMessageNotification : ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());
        context c = new context();
        public IViewComponentResult Invoke()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }


    }
}
