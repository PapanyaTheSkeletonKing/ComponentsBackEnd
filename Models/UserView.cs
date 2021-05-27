using System.Collections.Generic;
using Model;
using Utils;

namespace Models
{
	public class UserView
	{ 
		public string Login { get; set; }
		public string Email { get; set; }
		public bool LookingForJob { get; set; }
		public UserStatus Status { get; set; }
		public List<PostModel> Posts { get; set; }
	}
}