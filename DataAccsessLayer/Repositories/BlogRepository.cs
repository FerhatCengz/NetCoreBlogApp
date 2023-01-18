using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Repositories
{
    public class BlogRepository : IBlogDAL
    {
        public void AddBlog(Blog blog)
        {
            using (Context dbContext = new Context())
            {
                dbContext.Blogs.Add(blog);
                dbContext.SaveChanges();
            }
        }

        public void DeleteBlog(Blog blog)
        {
            using (Context dbContext = new Context())
            {
                dbContext.Blogs.Remove(blog);
                dbContext.SaveChanges();
            }
        }

        public Blog GetByID(int id)
        {
            using (Context dbContext = new Context())
            {
                return dbContext.Blogs.Find(id);
            }
        }

        public List<Blog> ListAllBlog()
        {
            using (Context dbContext = new Context())
            {
                return dbContext.Blogs.ToList();
            }
        }

        public void UpdateBlog(Blog blog)
        {
            using (Context dbContext = new Context())
            {
                dbContext.Blogs.Update(blog);
                dbContext.SaveChanges();
            }
        }
    }
}
