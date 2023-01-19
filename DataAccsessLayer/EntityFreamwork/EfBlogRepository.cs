using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFreamwork
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> GetBlogWithCategoryToList()
        {
            using (Context dbContext = new Context())
            {
                /*
                    Eager Loading kullanarak Verileri ihtiyaç hali dışında çağırıp bellekte saklıyoruz

                    Lazy Loading öyle değildir Lazy loading ihtiyaç halinde veri getirir mesela 1000 Satırlık veride bir satıra
                    İhtiyacınız var ise o satır getirilir kalkıpta tüm satırı getirmez.
                 */
                return dbContext.Blogs.Include(b => b.Category).ToList();
            }
        }
    }
}
