using System.Text.Json;
using Entities;

namespace Services.Mappers
{
	public static class FollowerMapper
	{
		public static FollowerModel ToFollowerModel(this UserEntity entity) => new FollowerModel
		{
			Login = entity.Login,
			Email = entity.Email,
			Image = entity.Image
		};
		public static string AsJson(this FollowerModel model) => 
			JsonSerializer.Serialize(model);
	}
}