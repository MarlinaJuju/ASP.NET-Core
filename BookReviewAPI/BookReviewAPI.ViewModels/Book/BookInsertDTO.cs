﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookReviewAPI.ViewModels.Book
{
    public class BookInsertDTO
    {
        [Required]
        public String Title { get; set; }

        public String Synopsis { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Edition { get; set; }
        [Required]
        public String ISBN { get; set; }

        [Required]
        public int AuthorId { get; set; }
        [Required]
        public int PublisherId { get; set; }
    }
}
