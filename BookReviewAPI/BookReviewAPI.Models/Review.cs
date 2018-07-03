using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookReviewAPI.Models
{
    public class Review:Entity
    {
        public String Description { get; set; }
        public int Rating { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public bool IsFinished { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int BookId { get; set; }

    }
}
