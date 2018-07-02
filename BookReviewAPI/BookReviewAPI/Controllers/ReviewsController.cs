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
    [Route("api/review")]
    public class ReviewsController:Controller
    {
        private readonly IBookReviewRepository _repository;
        public ReviewsController(IBookReviewRepository repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public IActionResult GetReviews()
        {
            return Ok(Mapper.Map<List<ReviewDTO>>(_repository.GetReviews()));
        }

        [HttpGet("user/{userId}")]
        public IActionResult GetReviewsByUser(int userId)
        {
            return Ok(Mapper.Map<List<ReviewDTO>>(_repository.GetReviewsByUserId(userId)));
        }

        [HttpGet("book/{bookId}")]
        public IActionResult GetReviewsByBook(int bookId)
        {
            return Ok(Mapper.Map<List<ReviewDTO>>(_repository.GetReviewsByBookId(bookId)));
        }

        [HttpGet("{id}", Name ="GetReviewDetail")]
        public IActionResult GetReviewDetail(int id)
        {
            var review = _repository.GetReview(id, true);
            if (review == null)
            {
                return NotFound();
            }
            return Ok (Mapper.Map<ReviewDetailDTO>(review));
        }

        [HttpPost]
        public IActionResult AddReview([FromBody]ReviewInsertDTO reviewInsertDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var review = _repository.GetReview(reviewInsertDTO.BookId, reviewInsertDTO.UserId);
            if (review != null)
            {
                return Conflict();
            }
            Review reviewInsert = Mapper.Map<Review>(reviewInsertDTO);
            reviewInsert.CreatedDate = DateTime.Now;
            if (!_repository.Add(reviewInsert))
            {
                return StatusCode(500);
            }
            return CreatedAtRoute("GetReviewDetail", new { id = review.Id }, Mapper.Map<ReviewDetailDTO>(review));
        }

        [HttpPut("{id}")]
        public IActionResult EditReview(int id, [FromBody] ReviewUpdateDTO reviewUpdateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var review = _repository.GetReview(id, false);
            if (review == null)
            {
                return NotFound();
            }
            Mapper.Map(reviewUpdateDTO, review);
            if (!_repository.Save()){
                return StatusCode(500);
            }
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PatchReview(int id, [FromBody]JsonPatchDocument<ReviewUpdateDTO> patchDoc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var review = _repository.GetReview(id, false);
            if (review == null)
            {
                return NotFound();
            }
            var reviewDTO = Mapper.Map<ReviewUpdateDTO>(review);
            patchDoc.ApplyTo(reviewDTO);
            Mapper.Map(reviewDTO, review);
            if (!_repository.Save())
            {
                return StatusCode(500);
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteReview(int id)
        {
            var review = _repository.GetReview(id, false);
            if (review == null)
            {
                return NotFound();
            }
            if (!_repository.Delete(review))
            {
                return StatusCode(500);
            }
            return NoContent();
        }
    }
}
