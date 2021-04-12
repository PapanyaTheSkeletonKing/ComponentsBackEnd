using System.Data.Entity;
using Entities;

namespace DAL
{
    public interface ISocialMediaContext
    {
        DbSet<UserEntity> Users { get; }
        DbSet<PostEntity> Posts { get; }
    }
}