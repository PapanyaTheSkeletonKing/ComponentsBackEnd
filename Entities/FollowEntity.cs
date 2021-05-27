using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Linq.Mapping;

namespace Entities
{
	public class FollowEntity
	{ 
		[ForeignKey("FollowerId")]
		public int FollowerId { get; set; }
		[ForeignKey("FollowedId")]
		public int FollowedId { get; set; }

		public UserEntity Follower { get; set; }
		
		public UserEntity Followed { get; set; }
	}
}