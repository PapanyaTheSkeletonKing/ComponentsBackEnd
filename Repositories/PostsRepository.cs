using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
	public class PostsRepository : GenericRepository<PostEntity>
	{

		public PostsRepository(DbSet<PostEntity> dataStorage) : base(dataStorage)
		{ }
	}
}