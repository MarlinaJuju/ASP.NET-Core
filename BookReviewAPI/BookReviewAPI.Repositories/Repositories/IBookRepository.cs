using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.Models;

namespace BookReviewAPI.Repositories.Repositories
{
    public interface IBookRepository : IBookReviewRepository<Book>
    {
        IEnumerable<Book> GetAll(bool includeAuthorAndPublisher);
        IEnumerable<Book> GetBooksByAuthorId(int authorId);
        IEnumerable<Book> GetBooksByPublisherId(int publisherId);
        IEnumerable<Book> GetBooksByAuthorIdAndPublisherId(int authorId, int publisherId);
        Book Get(int id, bool includeAuthorAndPublisher);
    }
}
