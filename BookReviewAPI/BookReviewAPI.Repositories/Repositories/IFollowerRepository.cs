using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.Models;

namespace BookReviewAPI.Repositories.Repositories
{
    public interface IFollowerRepository : IBookReviewRepository<Follower>
    {
        IEnumerable<Follower> GetFollowersByAuthorId(int authorId);
        IEnumerable<Follower> GetFollowersByAuthorIdIncludeUser(int authorId);
        IEnumerable<Follower> GetFollowersByUserId(int userId);
        IEnumerable<Follower> GetFollowersByUserIdIncludeAuthor(int userId);
        Follower Get(int userId, int authorId);
    }
}
