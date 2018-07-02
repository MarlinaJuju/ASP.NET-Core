using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Entities;

namespace BookReviewAPI.Models
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime EstabilishedDate { get; set; }
        public String Website { get; set; }
        public int NumberOfBooks {
            get
            {
                return Books.Count;
            }
        }

        private ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();
        public void SetBooks(ICollection<Book> books)
        {
            Books = books.Select(x => Mapper.Map<BookDTO>(x)).ToList();
        }
    }
}
