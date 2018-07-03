using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookReviewAPI.EntityFramework;
using BookReviewAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReviewAPI.Repositories.Repositories
{
    public class BookRepository : BookReviewRepository<Book>, IBookRepository
    {
        public BookRepository(BookReviewContext ctx) : base(ctx) { }

        public IEnumerable<Book> GetBooksByAuthorId(int authorId)
        {
            return GetAll(true).Where(x => x.AuthorId == authorId).ToList();
        }

        public IEnumerable<Book> GetBooksByPublisherId(int publisherId)
        {
            return GetAll(true).Where(x => x.PublisherId == publisherId).ToList();
        }

        public IEnumerable<Book> GetBooksByAuthorIdAndPublisherId(int authorId, int publisherId)
        {
            return GetAll(true).Where(x => x.PublisherId == publisherId && x.AuthorId == authorId).ToList();
        }

        public Book Get(int id, bool includeAuthorAndPublisher)
        {
            if (includeAuthorAndPublisher)
            {
                return _context.Books.Include(x => x.Author).Include(x => x.Publisher).FirstOrDefault(x => x.Id == id);
            }
            return Get(id);
        }

        public IEnumerable<Book> GetAll(bool includeAuthorAndPublisher)
        {
            if (includeAuthorAndPublisher)
            {
                return _context.Books.Include(x => x.Author).Include(x => x.Publisher).ToList();
            }
            return GetAll();
        }
    }
}
