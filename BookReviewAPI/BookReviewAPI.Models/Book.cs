using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookReviewAPI.Models
{
    public class Book:Entity
    {
        [Required]
        public String Title { get; set; }

        public String Synopsis { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Edition { get; set; }

        [Required]
        public String ISBN { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
