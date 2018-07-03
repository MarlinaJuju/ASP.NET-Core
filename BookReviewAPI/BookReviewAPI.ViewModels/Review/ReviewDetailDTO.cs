using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookReviewAPI.ViewModels.Review
{
    public class ReviewDetailDTO
    {
        private DateTime CreatedDate;
        public void SetCreatedDate(DateTime createdDate)
        {
            CreatedDate = createdDate;
        }
        public int Id { get; set; }
        public String Description { get; set; }
        public int Rating { get; set; }
        public String CreatedDateToString
        {
            get
            {
                return CreatedDate.ToString("dd MMM yyyy");
            }
        }

        [Required]
        public int UserId { get; set; }
        [Required]
        public int BookId { get; set; }

        public bool IsFinished { get; set; }
    }
}
