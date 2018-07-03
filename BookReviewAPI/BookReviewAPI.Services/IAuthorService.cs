using System;
using System.Collections.Generic;
using System.Text;
using BookReviewAPI.Models;
using BookReviewAPI.ViewModels.Author;

namespace BookReviewAPI.Services
{
    public interface IAuthorService
    {
        IEnumerable<AuthorDTO> GetAllAuthors();
        AuthorDetailDTO GetAuthorDTO(int id);
        Author GetAuthor(int id);
        void Add(AuthorInsertDTO authorInsertDTO);
        void Edit(int id,AuthorInsertDTO authorInsertDTO);
        AuthorInsertDTO ParseToInsertDTO(Author author);
        void EditPartial(AuthorInsertDTO authorInsertDTO, Author author);
        void Delete(int id);
    }
}
