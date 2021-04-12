using System.Data.Entity;
using DAL.Repositories;
using DAL.Repositories.Abstractions;
using EfRepository.Abstractions;
using EfRepository.Repositories;
using Entities;

namespace DAL
{
    public class UnitOfWork
    {
        private readonly ISocialMediaContext AppContext;
        public IRepository<UserEntity> Users { get; }
        public IRepository<PostEntity> Posts { get; }

        public UnitOfWork(ISocialMediaContext context)
        {
            AppContext = context;
            Users = new GenericRepository<UserEntity>(AppContext.Users);
            Posts = new GenericRepository<PostEntity>(AppContext.Posts);
        }
    }
}