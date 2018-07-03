using System;
using System.Collections.Generic;
using System.Text;

namespace BookReviewAPI.ViewModels.User
{
    public class UserChangePasswordDTO
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String NewPassword { get; set; }
    }
}
