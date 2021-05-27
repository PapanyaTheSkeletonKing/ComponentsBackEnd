using System.Collections.Generic;
using System.Linq;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstractions;

namespace Repositories
{
	public class FollowRepository :GenericRepository<FollowEntity>, IFollowRepository
	{
		public FollowRepository(DbSet<FollowEntity> dataStorage) : base(dataStorage)
		{ }

		public override List<FollowEntity> GetAll()
		{
			var value = _dataStorage.ToList();
			return value;
		}
	}
	
}