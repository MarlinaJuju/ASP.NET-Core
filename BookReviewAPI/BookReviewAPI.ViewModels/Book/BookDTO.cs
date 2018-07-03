using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookReviewAPI.ViewModels.Review;

namespace BookReviewAPI.ViewModels.Book
{
    public class BookDTO
    {
        public int Id { get; set; }
        public String Title { get; set; }

        public String Synopsis { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Edition { get; set; }
        public String ISBN { get; set; }

        public double Rating
        {
            get
            {
                return (Reviews.Count > 0) ? Reviews.Sum(x => x.Rating) / Reviews.Count : 0;
            }
        }
        private List<ReviewDTO> Reviews { get; set; } = new List<ReviewDTO>();
    }
}
