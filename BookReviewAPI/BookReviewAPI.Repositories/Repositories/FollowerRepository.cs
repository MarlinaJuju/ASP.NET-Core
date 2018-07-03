using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookReviewAPI.EntityFramework;
using BookReviewAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReviewAPI.Repositories.Repositories
{
    public class FollowerRepository : BookReviewRepository<Follower>, IFollowerRepository
    {

        public FollowerRepository(BookReviewContext ctx) : base(ctx)
        {

        }

        public Follower Get(int userId, int authorId)
        {
            return GetAll().FirstOrDefault(x => x.UserId == userId && x.AuthorId == authorId);
        }

        public IEnumerable<Follower> GetFollowersByAuthorId(int authorId)
        {
            return GetAll().Where(x => x.AuthorId == authorId).ToList();
        }

        public IEnumerable<Follower> GetFollowersByAuthorIdIncludeUser(int authorId)
        {
            return _context.Followers.Include(x => x.User).Where(x => x.AuthorId == authorId).ToList();
        }

        public IEnumerable<Follower> GetFollowersByUserId(int userId)
        {
            return GetAll().Where(x => x.UserId == userId).ToList();
        }

        public IEnumerable<Follower> GetFollowersByUserIdIncludeAuthor(int userId)
        {
            return _context.Followers.Include(x => x.Author).Where(x => x.UserId == userId).ToList();
        }
    }
}
