using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        Context dbContext = new Context();

        public void AddCategory(Category category)
        {
            dbContext.Add(category);
            dbContext.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            dbContext.Remove(category);
            dbContext.SaveChanges();
        }

        public Category GetByID(int id)
        {
            return dbContext.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return dbContext.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            dbContext.Update(category);
            dbContext.SaveChanges();
        }
    }
}
