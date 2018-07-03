using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.Models;

namespace BookReviewAPI.Repositories.Repositories
{
    public interface IPublisherRepository : IBookReviewRepository<Publisher>
    {
    }
}
