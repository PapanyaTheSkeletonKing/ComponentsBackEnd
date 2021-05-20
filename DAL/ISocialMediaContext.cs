using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public interface ISocialMediaContext
	{
		DbSet<UserEntity> Users { get; }
		DbSet<PostEntity> Posts { get; }
	}
}