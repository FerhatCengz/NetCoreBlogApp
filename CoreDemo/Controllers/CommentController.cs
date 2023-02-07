using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager _manager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogID = 2;
            _manager.CommentAdd(comment);
            return PartialView();
        }
        public PartialViewResult PartialCommentListByBlog(int id)
        {

            return PartialView(_manager.CommentGetList(id));
        }
    }
}
