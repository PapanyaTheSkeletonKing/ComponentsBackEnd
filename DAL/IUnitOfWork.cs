using Entities;
using Repositories;
using Repositories.Abstractions;


namespace DAL
{
	public interface IUnitOfWork
	{
		IUserRepository Users { get; }
		PostsRepository Posts { get; }
		IFollowRepository Followings { get; }

		void SaveChanges();
	}
}