using System.Text.Json;
using Entities;
using Model;
using Models;

namespace Services.Mappers
{
	public static class FollowMapper
	{
		public static FollowEntity ToEntity(this FollowModel entity) => new()
		{
			FollowedId = entity.FollowedId,
			FollowerId = entity.FollowerId
		};

		public static FollowModel ToModel(this FollowEntity entity) => new()
		{
			FollowerId = entity.FollowerId,
			FollowedId = entity.FollowedId
		};
		public static string AsJson(this FollowModel model) => 
			JsonSerializer.Serialize(model);
	}
}