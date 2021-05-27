using Entities;
using Repositories;
using Repositories.Abstractions;

namespace DAL
{
	public class UnitOfWork : IUnitOfWork
	{
		public readonly SocialMediaContext AppContext;
		public IUserRepository Users { get; }
		public PostsRepository Posts { get; }
		public IFollowRepository Followings { get; }

		public UnitOfWork(SocialMediaContext context)
		{
			AppContext = context;
			Users = new UserRepository(context.Users);
			Posts = new PostsRepository(context.Posts);
			Followings = new FollowRepository(context.Followings);
		}

		public void SaveChanges()
		{
			AppContext.SaveChanges();
		}
	}
}