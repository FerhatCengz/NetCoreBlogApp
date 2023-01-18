using BusinessLayer.Concrete;
using BusinessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class BlogController : Controller
	{
		BlogManager _manager = new BlogManager(new EfBlogRepository());
		public IActionResult BlogIndex()
		{
			return View(_manager.BlogGetList());
		}
	}
}
