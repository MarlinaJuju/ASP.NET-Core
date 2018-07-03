using System;
using System.Collections.Generic;
using System.Text;

namespace BookReviewAPI.Entity.Entities
{
    public class Author : Entity
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Email { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
        public ICollection<Follower> Followers { get; set; } = new List<Follower>();
    }
}
