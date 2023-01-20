using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.WriterLasBlog
{
	public class WriterLatBlogTop : ViewComponent
	{
		BlogManager _blogManager = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke(int id)
		{
			
			return View(_blogManager.BlogWithWriterByID(12));
		}
	}
}
