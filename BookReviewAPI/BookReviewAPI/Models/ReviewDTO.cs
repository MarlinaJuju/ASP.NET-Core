using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewAPI.Models
{
    public class ReviewDTO
    {
        private DateTime CreatedDate;
        public void SetCreatedDate(DateTime createdDate)
        {
            CreatedDate = createdDate;
        }
        private String description;
        public int Id { get; set; }
        public String Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Length > 200)
                {
                    description = value.Substring(0, 200)+" ...";
                }
                else
                {
                    description = value;
                }
            }
        }
        public int Rating { get; set; }
        public String CreatedDateToString {
            get
            {
                return CreatedDate.ToString("dd MMM yyyy");
            }
        }
    }
}
