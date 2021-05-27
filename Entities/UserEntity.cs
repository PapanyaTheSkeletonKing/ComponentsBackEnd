using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization;
using Utils;

namespace Entities
{
	public class UserEntity : IEntity
	{
		public int Id { get; set; }
		
		public string Login { get; set; } 
		public string Email { get; set; } 
		public string Password { get; set; }
		public byte[] Image { get; set; }

		public UserStatus Status { get; set; }

		public List<PostEntity> Posts { get; set; }
		
		public List<FollowEntity> Followeds { get; set; }
		public List<FollowEntity> Followers { get; set; }

		
	}
}