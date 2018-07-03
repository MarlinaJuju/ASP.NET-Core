using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Models;
using BookReviewAPI.Services;
using BookReviewAPI.ViewModels.Author;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BookReviewAPI.Controllers
{
    [Route("api/author")]
    public class AuthorsController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorsController( IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult getAllAuthors()
        {
            return Ok(_authorService.GetAllAuthors());
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult getAuthor(int id)
        {
            return Ok(_authorService.GetAuthor(id));
        }

        [HttpPost]
        public IActionResult addAuthor([FromBody]AuthorInsertDTO authorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _authorService.Add(authorDTO);
            return Ok();

        }

        [HttpPut("{id}")]
        public IActionResult editAuthor(int id, [FromBody]AuthorInsertDTO authorDTO)
        {
            _authorService.Edit(id, authorDTO);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult patchAuthor(int id, [FromBody]JsonPatchDocument<AuthorInsertDTO> patchDoc)
        {
            if (patchDoc == null)
            {
                return BadRequest();
            }
            var author = _authorService.GetAuthor(id);
            var authorDTO = _authorService.ParseToInsertDTO(author);
            patchDoc.ApplyTo(authorDTO, ModelState);
            _authorService.EditPartial(authorDTO, author);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteAuthor(int id)
        {
            _authorService.Delete(id);
            return NoContent();
        }
    }
}
