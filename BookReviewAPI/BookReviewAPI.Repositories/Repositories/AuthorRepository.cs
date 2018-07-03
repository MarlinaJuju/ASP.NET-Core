using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.EntityFramework;
using BookReviewAPI.Models;

namespace BookReviewAPI.Repositories.Repositories
{
    public class AuthorRepository : BookReviewRepository<Author>, IAuthorRepository
    {

        public AuthorRepository(BookReviewContext ctx) : base(ctx)
        {
        }
    }
}
