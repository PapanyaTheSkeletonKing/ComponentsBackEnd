using Entities;
using Repositories.Abstractions;


namespace DAL
{
	public interface IUnitOfWork
	{
		IRepository<UserEntity> Users { get; }
		IRepository<PostEntity> Posts { get; }

		void SaveChanges();
	}
}