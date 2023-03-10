using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.CommentList
{
    public class CommetListByBlog : ViewComponent
    {
        CommentManager _manager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id = 0)
        {
            
            return View(_manager.CommentGetList(id));
        }
    }
}
