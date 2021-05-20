using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DAL
{
	public class SocialMediaContext : DbContext
	{
		public DbSet<PostEntity> Posts { get; set; }
		public DbSet<UserEntity> Users { get; set; }

		public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
			: base(options)
		{ }



	}
}