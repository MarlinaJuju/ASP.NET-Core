using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Entities;

namespace BookReviewAPI.Models
{
    public class AuthorDetailDTO
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Email { get; set; }
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
