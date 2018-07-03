using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.ViewModels.Book;

namespace BookReviewAPI.ViewModels.Publisher
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
