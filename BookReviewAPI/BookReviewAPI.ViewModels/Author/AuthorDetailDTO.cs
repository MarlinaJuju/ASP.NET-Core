using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.ViewModels.Book;

namespace BookReviewAPI.ViewModels.Author
{
    public class AuthorDetailDTO
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Link { get; set; }
        public int NumberOfBook
        {
            get
            {
                return Books.Count;
            }
        }


        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();
    }
}
