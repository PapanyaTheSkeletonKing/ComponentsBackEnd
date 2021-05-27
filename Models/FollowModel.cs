using Model;

namespace Models
{
	public class FollowModel
	{
		public int Id { get; set; }
		
		public int FollowedId { get; set; }
		public int FollowerId { get; set; }
		
	}
}