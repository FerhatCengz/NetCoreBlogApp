using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _manager = new BlogManager(new EfBlogRepository());
        public IActionResult BlogIndex()
        {
            return View(_manager.BussinessGetBlogWithCategoryToList());
        }

        public IActionResult BlogReadAll(int id = 0)
        {
            ViewBag.idGet = id;
            return View(_manager.BlogGetList(id));
        }
    }
}
