using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookReviewAPI.Entity.Entities
{
    public class Follower:Entity
    {
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        public int AuthorId { get; set; }

    }
}
