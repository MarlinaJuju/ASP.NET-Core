using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookReviewAPI.ViewModels.Review
{
    public class ReviewUpdateDTO
    {
        public String Description { get; set; }
        [Required]
        public int Rating { get; set; }

        public bool IsFinished { get; set; }
    }
}
