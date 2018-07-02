using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewAPI.Models
{
    public class UserChangePasswordDTO
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String NewPassword { get; set; }
    }
}
