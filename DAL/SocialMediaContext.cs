using System.Data.Entity;
using Entities;

namespace DAL
{
    public class SocialMediaContext : DbContext, ISocialMediaContext
    {
        public DbSet<PostEntity> Posts { get; }
        public DbSet<UserEntity> Users { get; }
        
        public SocialMediaContext() : base("SocialDB")
        { }
        
        
        
    }
}