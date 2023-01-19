using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogServices
	{
		IBlogDAL _blogDal;

		public BlogManager(IBlogDAL blogDal)
		{
			_blogDal = blogDal;
		}



		public void BlogAdd(Blog blog)
		{
			_blogDal.Insert(blog);
		}

		public void BlogDelete(Blog blog)
		{
			_blogDal.Delete(blog);

		}

		public Blog BlogGetByID(int id)
		{
			return _blogDal.GetByID(id);

		}

		public List<Blog> BlogGetList()
		{
			return _blogDal.GetAllList();
		}

		public List<Blog> BlogGetList(int id)
		{
			return _blogDal.GetAllList(x => x.BlogID == id);
		}

		public void BlogUpdate(Blog blog)
		{
			_blogDal.Update(blog);
		}

		public List<Blog> BussinessGetBlogWithCategoryToList()
		{
			return _blogDal.GetBlogWithCategoryToList();
		}
	}
}
