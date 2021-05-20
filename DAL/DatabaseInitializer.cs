using System.Linq;
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

			context.Users.Add(new UserEntity
			{
				Email = "zhukovets.vetal322@gmail.com",
				Login = "vitalech",
				Password = "1",
				Status = UserStatus.Unauthorized,
				Image = System.IO.File.ReadAllBytes("ClientApp/event.png")
			});
			context.SaveChanges();

		}
	}
}