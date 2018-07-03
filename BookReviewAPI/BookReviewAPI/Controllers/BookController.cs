using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BookReviewAPI.Controllers
{
    [Route("api")]
    public class BookController : Controller
    {
        //private readonly IBookRepository _bookRepository;

        //public BookController(IBookRepository repo)
        //{
        //    _bookRepository = repo;
        //}


        //[HttpGet("book")]
        //public IActionResult GetBooks()
        //{
        //    return Ok(Mapper.Map<List<BookDTO>>(_bookRepository.GetAll(true)));
        //}

        //[HttpGet("book/publisher/{publisherId}")]
        //public IActionResult GetBooksByPublisherId(int publisherId)
        //{
        //    return Ok(Mapper.Map<List<BookDTO>>(_bookRepository.GetBooksByPublisherId(publisherId)));
        //}

        //[HttpGet("book/author/{authorId}")]
        //public IActionResult GetBooksByAuthorId(int authorId)
        //{
        //    return Ok(Mapper.Map<List<BookDTO>>(_bookRepository.GetBooksByAuthorId(authorId)));
        //}

        //[HttpGet("book/publisher/{publisherId}/author/{authorId}")]
        //public IActionResult GetBooksByPublisherIdAndAuthorId(int publisherId, int authorId)
        //{
        //    return Ok(Mapper.Map<List<BookDTO>>(_bookRepository.GetBooksByAuthorIdAndPublisherId(authorId, publisherId)));
        //}

        //[HttpGet("book/{id}")]
        //public IActionResult GetBook(int id)
        //{
        //    var book = _bookRepository.Get(id, true);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(Mapper.Map<BookDTO>(book));
        //}

        //[HttpGet("book/detail/{id}",Name ="GetDetailBook")]
        //public IActionResult GetDetailBook(int id)
        //{
        //    var book = _bookRepository.Get(id, true);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    var bookDTO = Mapper.Map<BookDetailDTO>(book);
        //    bookDTO.Author = book.Author.Name;
        //    bookDTO.Publisher = book.Publisher.Name;
        //    return Ok(bookDTO);
        //}

        //[HttpPost("book")]
        //public IActionResult AddBook([FromBody]BookInsertDTO bookInsertDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var book = Mapper.Map<Book>(bookInsertDTO);
        //    if (!_bookRepository.AddSaveChanges(book))
        //    {
        //        return StatusCode(500);
        //    }
        //    return CreatedAtRoute("GetDetailBook", new { id = book.Id }, bookInsertDTO);
        //}

        //[HttpPut("book/{id}")]
        //public IActionResult EditBook(int id, [FromBody]BookInsertDTO bookInsertDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }
        //    var book = _bookRepository.Get(id,false);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    Mapper.Map(bookInsertDTO, book);
        //    if (!_bookRepository.Save())
        //    {
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}
        //[HttpPatch("book/{id}")]
        //public IActionResult PatchBook(int id, [FromBody]JsonPatchDocument<BookInsertDTO> patchDoc)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }
        //    var book = _bookRepository.Get(id,false);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    var bookDTO = Mapper.Map<BookInsertDTO>(book);
        //    patchDoc.ApplyTo(bookDTO);
        //    Mapper.Map(bookDTO, book);
        //    if (!_bookRepository.Save())
        //    {
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}
        //[HttpDelete("book/{id}")]
        //public IActionResult DeleteBook(int id)
        //{
        //    var book = _bookRepository.Get(id,false);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    if (!_bookRepository.RemoveSaveChanges(book))
        //    {
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}
    }
}
