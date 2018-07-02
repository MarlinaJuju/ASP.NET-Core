using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviewAPI.Entities;

namespace BookReviewAPI.Services
{
    public interface IBookReviewRepository
    {
        IEnumerable<Author> GetAuthors();
        Author GetAuthor(int id);
        bool Add(Author author);
        bool Delete(Author author);

        IEnumerable<Publisher> GetPublishers();
        Publisher GetPublisher(int id);
        bool Add(Publisher publisher);
        bool Delete(Publisher publisher);

        IEnumerable<User> GetUsers();
        User GetUser(int id);
        bool Add(User user);
        bool Delete(User user);
        bool Login(string username, string password);
        
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetBooksByAuthorId(int authorId);
        IEnumerable<Book> GetBooksByPublisherId(int publisherId);
        IEnumerable<Book> GetBooksByAuthorIdAndPublisherId(int authorId, int publisherId);
        Book GetBook(int id, bool includeAuthorAndPublisher);
        bool Add(Book book);
        bool Delete(Book book);

        IEnumerable<Review> GetReviews();
        IEnumerable<Review> GetReviewsByUserId(int userId);
        IEnumerable<Review> GetReviewsByBookId(int bookId);
        Review GetReview(int bookId, int userId);
        Review GetReview(int id, bool includeUser);
        bool Add(Review review);
        bool Delete(Review review);

        bool Save();
    }
}
