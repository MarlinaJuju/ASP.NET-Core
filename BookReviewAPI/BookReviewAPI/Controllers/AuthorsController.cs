using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Entities;
using BookReviewAPI.Models;
using BookReviewAPI.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BookReviewAPI.Controllers
{
    [Route("api/author")]
    public class AuthorsController : Controller
    {
        private readonly IBookReviewRepository _repository;

        public AuthorsController(IBookReviewRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult getAllAuthors()
        {
            return Ok(Mapper.Map<IEnumerable<AuthorDTO>>(_repository.GetAuthors()));
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult getAuthor(int id)
        {
            Author author = _repository.GetAuthor(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<AuthorDetailDTO>(author));
        }

        [HttpPost]
        public IActionResult addAuthor([FromBody]AuthorInsertDTO authorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.First().Errors.First().ErrorMessage);
            }
            Author author = Mapper.Map<Author>(authorDTO);
            if (author == null)
            {
                return BadRequest();
            }
            if (!_repository.Add(author))
            {
                return StatusCode(500, "A problem happen when handling your request");
            }
            return CreatedAtRoute("GetAuthor", new { id = author.Id }, author);

        }

        [HttpPut("{id}")]
        public IActionResult editAuthor(int id, [FromBody]AuthorInsertDTO authorDTO)
        {
            Author author = _repository.GetAuthor(id);
            if (author == null)
            {
                return NotFound();
            }
            Mapper.Map(authorDTO, author);
            if (!_repository.Save())
            {
                return StatusCode(500, "A problem happen when handling your request");
            }
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult patchAuthor(int id, [FromBody]JsonPatchDocument<AuthorInsertDTO> patchDoc)
        {
            if (patchDoc == null)
            {
                return BadRequest();
            }
            var author = _repository.GetAuthor(id);
            if (author == null)
            {
                return NotFound();
            }
            var authorDTO = Mapper.Map<AuthorInsertDTO>(author);
            patchDoc.ApplyTo(authorDTO, ModelState);
            Mapper.Map(authorDTO, author);
            if (!_repository.Save())
            {
                return StatusCode(500, "A problem happen when handling your request");
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteAuthor(int id)
        {
            var author = _repository.GetAuthor(id);
            if (author == null)
            {
                return NotFound();
            }
            if (!_repository.Delete(author))
            {
                return StatusCode(500, "A problem happen when handling your request");
            }
            return NoContent();
        }
    }
}
