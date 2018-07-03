using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookReviewAPI.Models
{
    public class Publisher:Entity
    {
        [Required]
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime EstabilishedDate { get; set; }
        public String Website { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
