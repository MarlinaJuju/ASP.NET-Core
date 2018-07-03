using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookReviewAPI.ViewModels.Publisher
{
    public class PublisherInsertDTO
    {
        [Required]
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime EstabilishedDate { get; set; }
        public String Website { get; set; }
    }
}
