using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.EntityFramework;
using BookReviewAPI.Models;

namespace BookReviewAPI.Repositories.Repositories
{
    public class UserRepository : BookReviewRepository<User>, IUserRepository
    {
        public UserRepository(BookReviewContext ctx) : base(ctx)
        {

        }
    }
}
