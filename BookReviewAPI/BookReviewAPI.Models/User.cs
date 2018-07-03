using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookReviewAPI.Models
{
    public class User : Entity
    {
        [Required]
        public String Username { get; set; }
        [Required]
        public String Password { get; set; }
        public String Description { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Follower> Followers { get; set; } = new List<Follower>();
    }
}
