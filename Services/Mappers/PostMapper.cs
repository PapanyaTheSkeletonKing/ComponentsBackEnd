using Entities;
using Model;

namespace Services.Mappers
{
	public static class PostMapper
	{
		public static PostEntity ToEntity(this PostModel entity) => new()
		{
			UserId = entity.Author.Id,
			CreationDate = entity.CreationDate,
			Text = entity.Text
		};
		
		public static PostModel ToModel(this PostEntity entity) => new()
		{
			Id = entity.Id,
			Author = entity.Author.ToModel(),
			CreationDate = entity.CreationDate,
			Text = entity.Text
		};
	
	}
}