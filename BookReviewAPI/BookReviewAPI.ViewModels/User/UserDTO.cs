using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookReviewAPI.ViewModels.User
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        public String Username { get; set; }
        [Required]
        public String Password { get; set; }
        public String Description { get; set; }

    }
}
