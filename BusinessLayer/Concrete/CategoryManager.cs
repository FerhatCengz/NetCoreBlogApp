using BusinessLayer.Abstract;
using BusinessLayer.EntityFreamwork;
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
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public Category CategoryGetByID(int id)
        {
            return efCategoryRepository.GetByID(id);
        }

        public List<Category> CategoryGetList(Category category)
        {
            return efCategoryRepository.GetAllList();
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}
