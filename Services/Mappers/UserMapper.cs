using System.Collections.Generic;
using System.Linq;
using Entities;
using Model;

namespace Services.Mappers
{
	public static class UserMapper
	{
		public static UserModel ToModel(this UserEntity entity) => new()
		{
			Id = entity.Id,
			Email = entity.Email,
			Password = entity.Password,
			Login = entity.Login,
			Image = entity.Image,
			LookingForJob = true,
			Posts = entity.Posts == null
				? new List<PostModel>() 
				: entity.Posts
					.Select(post => post.ToModel())
					.ToList(),
			Status = entity.Status
		};

		public static UserEntity ToEntity(this UserModel entity) => new()
		{
			Login = entity.Login,
			Email = entity.Email,
			Password = entity.Password,
			Image = entity.Image,
			Status = entity.Status,
		};
	}
}