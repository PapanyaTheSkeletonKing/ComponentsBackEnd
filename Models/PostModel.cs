using System;

namespace Model
{
	public class PostModel : IModel
	{
		public int Id { get; set; }
		public UserModel Author { get; set; }

		public string Text { get; set; }
		public DateTime CreationDate { get; set; }

	}
}