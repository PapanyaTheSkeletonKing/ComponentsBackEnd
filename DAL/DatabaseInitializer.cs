using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Entities;
using Utils;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
	public static class DatabaseInitializer
	{
		public static void Initialize(SocialMediaContext context)
		{
			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();

			context.Users.AddRange(new List<UserEntity> 
			{
				new UserEntity
				{
					Email = "nazarius9@gmail.com",
					Login = "naxar",
					Password = "2",
					Status = UserStatus.Unauthorized,
					Image = System.IO.File.ReadAllBytes("event.png")
				},
				new UserEntity
				{
					Email = "zhukovets.vetal322@gmail.com",
					Login = "vitalech",
					Password = "1",
					Status = UserStatus.Unauthorized,
					Image = System.IO.File.ReadAllBytes("event.png")
				},
				new UserEntity
				{
					Email = "chel3232",
					Login = "dsdsds",
					Password = "123",
					Status = UserStatus.Unauthorized,
					Image = System.IO.File.ReadAllBytes("event.png")
				}
				
			});
			context.SaveChanges();

			context.Followings.AddRange(new List<FollowEntity>
			{ 
				new FollowEntity
				{
						FollowerId = 1,
						FollowedId = 2
				},
				new FollowEntity
				{
					FollowerId = 2,
					FollowedId = 2
				}
				
			});
			context.SaveChanges();
			
			var u = context.Users.ToList();
			var q = context.Followings.ToList();
		}
	}
}