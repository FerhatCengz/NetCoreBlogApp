using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IBlogDAL
    {
        List<Blog> ListAllBlog();
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void UpdateBlog(Blog blog);
        Blog GetByID(int id);
    }
}
