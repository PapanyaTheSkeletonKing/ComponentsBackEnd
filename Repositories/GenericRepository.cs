using System.Collections.Generic;
using System.Linq;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstractions;

namespace Repositories
{
	public class GenericRepository<TEntity> : IRepository<TEntity>
		where TEntity : class, IEntity

	{
		private readonly DbSet<TEntity> DataStorage;

		public GenericRepository(DbSet<TEntity> dataStorage)
		{
			DataStorage = dataStorage;
		}

		public void Delete(int id)
		{
			var toDelete = DataStorage
				.Find(id);

			DataStorage.ToList().Remove(toDelete);
		}

		public List<TEntity> GetAll()
		{
			return DataStorage.ToList();
		}


		public TEntity GetById(int id)
		{
			return DataStorage.Find(id);
		}

		public void Add(TEntity obj)
		{
			DataStorage.Add(obj);
		}

		public void Update(TEntity obj)
		{
			DataStorage.Update(obj);
		}
	}
}