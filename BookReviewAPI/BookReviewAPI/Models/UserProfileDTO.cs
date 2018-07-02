using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Entities;

namespace BookReviewAPI.Models
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
        public void SetReviews(ICollection<Review> reviews)
        {
            Reviews = reviews.Select(x => Mapper.Map<ReviewDTO>(x)).ToList();
        }
    }
}
