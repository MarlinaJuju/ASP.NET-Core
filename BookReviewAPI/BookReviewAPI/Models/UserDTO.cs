using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Entities;

namespace BookReviewAPI.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        public String Username { get; set; }
        [Required]
        public String Password { get; set; }
        public String Description { get; set; }
        
    }
}
