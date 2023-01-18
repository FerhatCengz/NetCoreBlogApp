using BusinessLayer.Abstract;
using BusinessLayer.EntityFreamwork;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDAL.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public Category CategoryGetByID(int id)
        {
            return _categoryDAL.GetByID(id);
        }

        public List<Category> CategoryGetList()
        {
            return _categoryDAL.GetAllList();
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}
