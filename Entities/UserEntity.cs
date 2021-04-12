using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Entities
{
    public class UserEntity: IEntity
    {
        public int Id { get; set; } 
        
        public string Username { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<PostEntity> Posts { get; set; }
        
    }
}