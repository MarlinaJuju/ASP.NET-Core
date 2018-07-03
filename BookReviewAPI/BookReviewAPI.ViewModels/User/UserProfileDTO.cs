using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BookReviewAPI.ViewModels.Review;

namespace BookReviewAPI.ViewModels.User
{
    public class UserProfileDTO
    {
        [Required]
        public String Username { get; set; }
        public String Description { get; set; }
        public int NumberOfReview
        {
            get
            {
                return Reviews.Count;
            }
        }

        private ICollection<ReviewDTO> Reviews { get; set; } = new List<ReviewDTO>();
    }
}
