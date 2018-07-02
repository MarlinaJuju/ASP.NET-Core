using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewAPI.Entities
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Email { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
        public ICollection<Follower> Followers { get; set; } = new List<Follower>();
    }
}
