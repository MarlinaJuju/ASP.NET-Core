using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookReviewAPI.EntityFramework;
using BookReviewAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReviewAPI.Repositories.Repositories
{
    public class ReviewRepository : BookReviewRepository<Review>, IReviewRepository
    {
        public ReviewRepository(BookReviewContext ctx) : base(ctx)
        {

        }
        public IEnumerable<Review> GetReviewsByUserId(int userId)
        {
            return GetAll().Where(x => x.UserId == userId);
        }

        public IEnumerable<Review> GetReviewsByBookId(int bookId)
        {
            return GetAll().Where(x => x.BookId == bookId);
        }

        public Review Get(int bookId, int userId)
        {
            return GetAll().FirstOrDefault(x => x.BookId == bookId && x.UserId == userId);
        }

        public Review Get(int id, bool includeUser)
        {
            if (includeUser)
            {
                return _context.Reviews.Include(x => x.User).FirstOrDefault(x => x.Id == id);
            }
            return Get(id);
        }

        public IEnumerable<Review> GetAll(bool includeUser)
        {
            if (includeUser)
            {
                return _context.Reviews.Include(x => x.User);
            }
            return GetAll();
        }
    }
}
