using BusinessLayer.Concrete;
using BusinessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _manager = new CategoryManager(new EfCategoryRepository());
        public IActionResult CategoryIndex()
        {
            return View(_manager.CategoryGetList());
        }
    }
}
