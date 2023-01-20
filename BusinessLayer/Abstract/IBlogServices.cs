using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogServices
	{
		void BlogAdd(Blog blog);
		void BlogUpdate(Blog blog);
		void BlogDelete(Blog blog);
		List<Blog> BlogGetList();
		Blog BlogGetByID(int id);

		List<Blog> BussinessGetBlogWithCategoryToList(int id);

		List<Blog> BlogGetList(int id);
		List<Blog> BlogWithWriterByID(int id);

	}
}
