using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Repositories
{
	public class GenericRepository<TEntity> : IGenericDAL<TEntity> where TEntity : class
	{
		public void Delete(TEntity entity)
		{
			using (Context dbContext = new Context())
			{
				dbContext.Remove(entity);
				dbContext.SaveChanges();
			}
		}

		public List<TEntity> GetAllList()
		{
			using (Context dbContext = new Context())
			{
				return dbContext.Set<TEntity>().ToList();
			}
		}

		public TEntity GetByID(int entityID)
		{
			using (Context dbContext = new Context())
			{
				return dbContext.Set<TEntity>().Find(entityID);
			}
		}

		public void Insert(TEntity entity)
		{
			using (Context dbContext = new Context())
			{
				dbContext.Add(entity);
				dbContext.SaveChanges();
			}
		}

		public List<TEntity> GetAllList(Expression<Func<TEntity, bool>> filter)
		{
			using (Context dbContext = new Context())
			{
				return dbContext.Set<TEntity>().Where(filter).ToList();
			}
		}

		public void Update(TEntity entity)
		{
			using (Context dbContext = new Context())
			{
				dbContext.Update(entity);
				dbContext.SaveChanges();
			}
		}
	}
}
