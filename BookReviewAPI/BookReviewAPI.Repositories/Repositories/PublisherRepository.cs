using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.EntityFramework;
using BookReviewAPI.Models;

namespace BookReviewAPI.Repositories.Repositories
{
    public class PublisherRepository : BookReviewRepository<Publisher>, IPublisherRepository
    {
        public PublisherRepository(BookReviewContext ctx) : base(ctx)
        {
        }
    }
}
