using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface ICategoryDAL
    {
        List<Category> ListAllCategory();
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
        Category GetByID(int id);


    }
}
