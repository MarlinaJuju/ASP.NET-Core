using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Entities;

namespace BookReviewAPI.Models
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public String Description { get; set; }
        public String Email { get; set; }
        public int NumberOfBook { get
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
