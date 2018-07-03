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
    [Route("api/review")]
    public class ReviewsController:Controller
    {
        //private readonly IReviewRepository _reviewRepository;
        //public ReviewsController(IReviewRepository repo)
        //{
        //    _reviewRepository = repo;
        //}

        //[HttpGet]
        //public IActionResult GetReviews()
        //{
        //    return Ok(Mapper.Map<List<ReviewDTO>>(_reviewRepository.GetAll(true)));
        //}

        //[HttpGet("user/{userId}")]
        //public IActionResult GetReviewsByUser(int userId)
        //{
        //    return Ok(Mapper.Map<List<ReviewDTO>>(_reviewRepository.GetReviewsByUserId(userId)));
        //}

        //[HttpGet("book/{bookId}")]
        //public IActionResult GetReviewsByBook(int bookId)
        //{
        //    return Ok(Mapper.Map<List<ReviewDTO>>(_reviewRepository.GetReviewsByBookId(bookId)));
        //}

        //[HttpGet("{id}", Name ="GetReviewDetail")]
        //public IActionResult GetReviewDetail(int id)
        //{
        //    var review = _reviewRepository.Get(id, true);
        //    if (review == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok (Mapper.Map<ReviewDetailDTO>(review));
        //}

        //[HttpPost]
        //public IActionResult AddReview([FromBody]ReviewInsertDTO reviewInsertDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var review = _reviewRepository.Get(reviewInsertDTO.BookId, reviewInsertDTO.UserId);
        //    if (review != null)
        //    {
        //        return Conflict();
        //    }
        //    Review reviewInsert = Mapper.Map<Review>(reviewInsertDTO);
        //    reviewInsert.CreatedDate = DateTime.Now;
        //    if (!_reviewRepository.AddSaveChanges(reviewInsert))
        //    {
        //        return StatusCode(500);
        //    }
        //    return CreatedAtRoute("GetReviewDetail", new { id = review.Id }, Mapper.Map<ReviewDetailDTO>(review));
        //}

        //[HttpPut("{id}")]
        //public IActionResult EditReview(int id, [FromBody] ReviewUpdateDTO reviewUpdateDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var review = _reviewRepository.Get(id);
        //    if (review == null)
        //    {
        //        return NotFound();
        //    }
        //    Mapper.Map(reviewUpdateDTO, review);
        //    if (!_reviewRepository.Save()){
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}

        //[HttpPatch("{id}")]
        //public IActionResult PatchReview(int id, [FromBody]JsonPatchDocument<ReviewUpdateDTO> patchDoc)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var review = _reviewRepository.Get(id);
        //    if (review == null)
        //    {
        //        return NotFound();
        //    }
        //    var reviewDTO = Mapper.Map<ReviewUpdateDTO>(review);
        //    patchDoc.ApplyTo(reviewDTO);
        //    Mapper.Map(reviewDTO, review);
        //    if (!_reviewRepository.Save())
        //    {
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}
        //[HttpDelete("{id}")]
        //public IActionResult DeleteReview(int id)
        //{
        //    var review = _reviewRepository.Get(id);
        //    if (review == null)
        //    {
        //        return NotFound();
        //    }
        //    if (!_reviewRepository.RemoveSaveChanges(review))
        //    {
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}
    }
}
