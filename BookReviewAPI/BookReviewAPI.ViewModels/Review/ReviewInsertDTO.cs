using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookReviewAPI.ViewModels.Review
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
