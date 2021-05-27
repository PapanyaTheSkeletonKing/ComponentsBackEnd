using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
	public class UserRepository : GenericRepository<UserEntity>, IUserRepository 
	{

		public UserRepository(DbSet<UserEntity> dataStorage) : base(dataStorage)
		{ }

		public override UserEntity GetById(int id)
		{
			
			var user = _dataStorage.Find(id);
			return user;
		}

	}
}