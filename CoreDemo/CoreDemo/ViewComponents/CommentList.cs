using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Components
{
    [ViewComponent]
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {

            CommentManager cm = new CommentManager(new EfCommentRepository());
            var commentValues = cm.List(id);
            return View(commentValues);
        }
    }
}
