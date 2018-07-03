using System;
using System.Collections.Generic;
using System.Text;

namespace BookReviewAPI.Repositories.Repositories
{
    public interface IBookReviewRepository<T> where T : class
    {
        void Add(T t);
        bool AddSaveChanges(T t);
        void Edit(T t);
        bool EditSaveChanges(T t);
        T Get(int id);
        IEnumerable<T> GetAll();
        void Remove(T t);
        bool RemoveSaveChanges(T t);

        bool Save();
    }
}
