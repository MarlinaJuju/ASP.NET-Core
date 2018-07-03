using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BookReviewAPI.Models;
using BookReviewAPI.Repositories.Repositories;
using BookReviewAPI.ViewModels.Author;
using ExceptionHandlingMiddleware;

namespace BookReviewAPI.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(AuthorInsertDTO authorInsertDTO)
        {
            Author author = Mapper.Map<Author>(authorInsertDTO);
            if (author == null)
            {
                throw new NotFoundException();
            }
            if (!_authorRepository.AddSaveChanges(author))
            {
                throw new InternalServerErrorException();
            }
        }

        public void Delete(int id)
        {
            var author = GetAuthor(id);
            if (!_authorRepository.RemoveSaveChanges(author))
            {
                throw new InternalServerErrorException();
            }
        }

        public void Edit(int id, AuthorInsertDTO authorInsertDTO)
        {
            Author author = GetAuthor(id);
            Mapper.Map(authorInsertDTO, author);
            if (!_authorRepository.Save())
            {
                throw new InternalServerErrorException();
            }
        }

        public void EditPartial(AuthorInsertDTO authorInsertDTO, Author author)
        {
            Mapper.Map(authorInsertDTO, author);
            if (!_authorRepository.Save())
            {
                throw new InternalServerErrorException();
            }
        }

        public IEnumerable<AuthorDTO> GetAllAuthors()
        {
            return Mapper.Map<IEnumerable<AuthorDTO>>(_authorRepository.GetAll());
        }

        public Author GetAuthor(int id)
        {
            var author = _authorRepository.Get(id);
            if (author == null)
            {
                throw new NotFoundException();
            }
            return author;
        }

        public AuthorDetailDTO GetAuthorDTO(int id)
        {
            return Mapper.Map<AuthorDetailDTO>(GetAuthor(id));
        }

        public AuthorInsertDTO ParseToInsertDTO(Author author)
        {
            return Mapper.Map<AuthorInsertDTO>(author);
        }
    }
}
