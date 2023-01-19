using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
	public interface IGenericDAL<TEntity> where TEntity : class
	{
		void Insert(TEntity entity);
		void Delete(TEntity entity);
		void Update(TEntity entity);
		List<TEntity> GetAllList();
		TEntity GetByID(int entityID);

		List<TEntity> GetAllList(Expression<Func<TEntity, bool>> filter);

	}
}
