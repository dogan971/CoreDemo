using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());


        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.commentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.commentStatus = true;
            p.blogID = 4;
            cm.Add(p);
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {

            return PartialView();
        }
        [HttpGet]
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.List(id);
            return PartialView(values);
        }
    }
}
