using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public interface ISocialMediaContext
	{
		DbSet<UserEntity> Users { get; set; }
		DbSet<PostEntity> Posts { get; set; }
		DbSet<FollowEntity> FollowEntities { get; set; }
	}
}