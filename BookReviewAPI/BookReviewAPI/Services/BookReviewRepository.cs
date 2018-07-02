using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviewAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookReviewAPI.Services
{
    public class BookReviewRepository : IBookReviewRepository
    {
        private readonly BookReviewContext _context;

        public BookReviewRepository(BookReviewContext ctx)
        {
            _context = ctx;
        }

        public bool Add(Author author)
        {
            _context.Authors.Add(author);
            return Save();
        }

        public bool Add(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            return Save();
        }

        public bool Add(User user)
        {
            _context.Users.Add(user);
            return Save();
        }

        public bool Delete(Author author)
        {
            _context.Authors.Remove(author);
            return Save();
        }

        public bool Delete(Publisher publisher)
        {
            _context.Publishers.Remove(publisher);
            return Save();
        }

        public bool Delete(User user)
        {
            _context.Users.Remove(user);
            return Save();
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Include(x=>x.Books).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _context.Authors.Include(x=>x.Books).ToList();
        }

        public Publisher GetPublisher(int id)
        {
            return _context.Publishers.Include(x=>x.Books).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Publisher> GetPublishers()
        {
            return _context.Publishers.Include(x=>x.Books).ToList();
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.Include(x=>x.Reviews).ToList();
        }

        public User GetUser(int id)
        {
            return _context.Users.Include(x=>x.Reviews).FirstOrDefault(x => x.Id == id);
        }

        public bool Login(string username, string password)
        {
            return (_context.Users.Count(x => x.Username == username && x.Password == password) >= 0);
        }

        

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public IEnumerable<Book> GetBooksByAuthorId(int authorId)
        {
            return _context.Books.Where(x => x.AuthorId == authorId).ToList();
        }

        public IEnumerable<Book> GetBooksByPublisherId(int publisherId)
        {
            return _context.Books.Where(x => x.PublisherId == publisherId).ToList();
        }

        public IEnumerable<Book> GetBooksByAuthorIdAndPublisherId(int authorId, int publisherId)
        {
            return _context.Books.Where(x => x.PublisherId == publisherId && x.AuthorId == authorId).ToList();
        }

        public Book GetBook(int id, bool includeAuthorAndPublisher)
        {
            if (includeAuthorAndPublisher)
            {
                return _context.Books.Include(x=>x.Author).Include(x=>x.Publisher).FirstOrDefault(x => x.Id == id);
            }
            return _context.Books.FirstOrDefault(x => x.Id == id);
        }

        public bool Add(Book book)
        {
            _context.Books.Add(book);
            return Save();
        }

        public bool Delete(Book book)
        {
            _context.Books.Remove(book);
            return Save();
        }

        public IEnumerable<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public IEnumerable<Review> GetReviewsByUserId(int userId)
        {
            return _context.Reviews.Where(x => x.UserId == userId);
        }

        public IEnumerable<Review> GetReviewsByBookId(int bookId)
        {
            return _context.Reviews.Where(x => x.BookId == bookId);
        }

        public Review GetReview(int bookId, int userId)
        {
            return _context.Reviews.FirstOrDefault(x => x.BookId == bookId && x.UserId == userId);
        }

        public Review GetReview(int id, bool includeUser)
        {
            if (includeUser)
            {
                return _context.Reviews.Include(x => x.User).FirstOrDefault(x => x.Id == id);
            }
            return _context.Reviews.FirstOrDefault(x => x.Id == id);
        }

        public bool Add(Review review)
        {
            _context.Reviews.Add(review);
            return Save();
        }

        public bool Delete(Review review)
        {
            _context.Reviews.Remove(review);
            return Save();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
