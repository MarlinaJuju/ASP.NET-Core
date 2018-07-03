using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookReviewAPI.EntityFramework;
using BookReviewAPI.Models;

namespace BookReviewAPI.Repositories.Repositories
{
    public class BookReviewRepository<T> : IBookReviewRepository<T> where T : class
    {
        protected readonly BookReviewContext _context;
        public BookReviewRepository(BookReviewContext ctx)
        {
            _context = ctx;
        }
        public void Add(T t)
        {
            _context.Set<T>().Add(t);
        }

        public bool AddSaveChanges(T t)
        {
            Add(t);
            return Save();
        }

        public void Edit(T t)
        {
            _context.Set<T>().Update(t);
        }

        public bool EditSaveChanges(T t)
        {
            Edit(t);
            return Save();
        }

        public T Get(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => (x as Entity).Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Remove(T t)
        {
            _context.Set<T>().Remove(t);
        }

        public bool RemoveSaveChanges(T t)
        {
            Remove(t);
            return Save();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
