using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.Models;

namespace BookReviewAPI.Repositories.Repositories
{
    public interface IReviewRepository : IBookReviewRepository<Review>
    {
        IEnumerable<Review> GetAll(bool includeUser);
        IEnumerable<Review> GetReviewsByUserId(int userId);
        IEnumerable<Review> GetReviewsByBookId(int bookId);
        Review Get(int bookId, int userId);
        Review Get(int id, bool includeUser);
    }
}
