using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Entities;

namespace BookReviewAPI.Models
{
    public class BookDTO
    {
        public int Id { get; set; }
        public String Title { get; set; }

        public String Synopsis { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Edition { get; set; }
        public String ISBN { get; set; }

        public double Rating {
            get
            {
                return (Reviews.Count>0)? Reviews.Sum(x => x.Rating) / Reviews.Count:0;
            }
        }
        private List<ReviewDTO> Reviews { get; set; } = new List<ReviewDTO>();
        public void SetReviews(ICollection<Review> reviews)
        {
            Reviews = reviews.Select(x=>Mapper.Map<ReviewDTO>(x)).ToList();
        }
    }
}
