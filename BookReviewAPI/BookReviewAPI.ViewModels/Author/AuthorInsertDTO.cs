using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookReviewAPI.ViewModels.Author
{
    public class AuthorInsertDTO
    {
        [Required]
        public String Name { get; set; }
        public String Description { get; set; }
        public String Link { get; set; }
    }
}
