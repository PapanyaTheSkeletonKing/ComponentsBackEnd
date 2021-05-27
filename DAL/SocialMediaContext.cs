using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public class SocialMediaContext : DbContext
	{
		public DbSet<PostEntity> Posts { get; set; }
		public DbSet<UserEntity> Users { get; set; }
		public DbSet<FollowEntity> Followings { get; set; }

		public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
			: base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<FollowEntity>()
				.HasKey(entity =>
				new { entity.FollowerId, entity.FollowedId });
			
			modelBuilder.Entity<FollowEntity>()
				.HasOne(f => f.Followed)
				.WithMany(u => u.Followeds)
				.HasForeignKey(f => f.FollowedId)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<FollowEntity>()
				.HasOne(f => f.Follower)
				.WithMany(fw => fw.Followers)
				.HasForeignKey(f => f.FollowerId)
				.OnDelete(DeleteBehavior.Restrict);

			}
	}
}