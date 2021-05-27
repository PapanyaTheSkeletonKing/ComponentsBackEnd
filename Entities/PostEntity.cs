using System;

namespace Entities
{
	public class PostEntity : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }

		public string Text { get; set; }
		public DateTime CreationDate { get; set; }

		public UserEntity Author { get; set; }
	}
}