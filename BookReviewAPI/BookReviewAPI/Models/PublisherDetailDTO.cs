using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewAPI.Models
{
    public class PublisherDetailDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime EstabilishedDate { get; set; }
        public String Website { get; set; }
        public int NumberOfBooks
        {
            get
            {
                return Books.Count;
            }
        }

        public ICollection<BookDTO> Books { get; set; }
    }
}
