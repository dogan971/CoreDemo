using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents
{
    [ViewComponent]
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
        public IViewComponentResult Invoke()
        {
            context c = new context();
            var userMail = User.Identity.Name;
            var id = wm.writerFilter(x => x.writerMail == userMail).writerID;
            var values = wm.GetWriterbyID(id);
            return View(values);
        }


    }
}
