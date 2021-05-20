using Entities;
using Repositories;
using Repositories.Abstractions;

namespace DAL
{
	public class UnitOfWork : IUnitOfWork
	{
		public readonly SocialMediaContext AppContext;
		public IRepository<UserEntity> Users { get; }
		public IRepository<PostEntity> Posts { get; }

		public UnitOfWork(SocialMediaContext context)
		{
			AppContext = context;
			Users = new GenericRepository<UserEntity>(context.Users);
			Posts = new GenericRepository<PostEntity>(context.Posts);
		}

		public void SaveChanges()
		{
			AppContext.SaveChanges();
		}
	}
}