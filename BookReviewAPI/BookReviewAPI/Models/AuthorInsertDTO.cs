using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewAPI.Models
{
    public class AuthorInsertDTO
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Email { get; set; }
    }
}
