using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewAPI.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String Username { get; set; }
        [Required]
        public String Password { get; set; }
        public String Description { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Follower> Followers { get; set; } = new List<Follower>();
    }
}
