using System.Collections.Generic;
using System.Linq;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstractions;

namespace Repositories
{
	public class GenericRepository<TEntity> where TEntity : class

	{
		protected readonly DbSet<TEntity> _dataStorage;

		public GenericRepository(DbSet<TEntity> dataStorage)
		{
			_dataStorage = dataStorage;
		}

		public virtual void Delete(int id)
		{
			var toDelete = _dataStorage
				.Find(id);

			_dataStorage.ToList().Remove(toDelete);
		}

		public virtual List<TEntity> GetAll()
		{
			var list = _dataStorage.ToList();
			return list;
		}


		public virtual TEntity GetById(int id)
		{
			var entity = _dataStorage.Find(id);
			return entity;
		}

		public virtual void Add(TEntity obj)
		{
			_dataStorage.Add(obj);
		}

		public virtual void Update(TEntity obj)
		{
			_dataStorage.Update(obj);
		}
	}
}