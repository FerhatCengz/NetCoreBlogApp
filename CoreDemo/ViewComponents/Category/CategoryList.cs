using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager _manager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
        
            return View(_manager.CategoryGetList());
        }
    }
}
