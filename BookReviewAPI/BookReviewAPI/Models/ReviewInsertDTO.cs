using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewAPI.Models
{
    public class ReviewInsertDTO
    {
        public String Description { get; set; }
        [Required]
        public int Rating { get; set; }

        [Required]
        public int UserId { get; set; }
        [Required]
        public int BookId { get; set; }

        public bool IsFinished { get; set; }
    }
}
