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
    [Route("api/publisher")]
    public class PublishersController : Controller
    {
        private readonly IBookReviewRepository _repository;

        public PublishersController(IBookReviewRepository repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public IActionResult GetPublishers()
        {
            return Ok(Mapper.Map<IEnumerable<PublisherDTO>>(_repository.GetPublishers()));
        }

        [HttpGet("{id}", Name = "GetPublisher")]
        public IActionResult GetPublisher(int id)
        {
            var publisher = _repository.GetPublisher(id);
            if (publisher == null)
            {
                return NotFound();
            }
            var publisherDTO = Mapper.Map<PublisherDetailDTO>(publisher);
            return Ok(publisherDTO);
        }

        [HttpPost]
        public IActionResult addPublisher([FromBody]PublisherInsertDTO publisherDTO)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(BadRequest().StatusCode, ModelState.Values.First().Errors.First().ErrorMessage);
            }
            var publisher = Mapper.Map<Publisher>(publisherDTO);
            if (publisher == null)
            {
                return BadRequest();
            }
            if (!_repository.Add(publisher))
            {
                return StatusCode(500, "internal server error");
            }
            return CreatedAtRoute("GetPublisher", new { id = publisher.Id }, publisher);
        }

        [HttpPut("{id}")]
        public IActionResult editPublisher(int id, [FromBody] PublisherInsertDTO publisherDTO)
        {
            if (publisherDTO == null)
            {
                return BadRequest();
            }
            var publisher = _repository.GetPublisher(id);
            if (publisher == null)
            {
                return NotFound();
            }
            Mapper.Map(publisherDTO, publisher);
            if (!_repository.Save())
            {
                return StatusCode(500, "internal server error");
            }
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult patchPublisher(int id, [FromBody]JsonPatchDocument<PublisherInsertDTO> patchDoc)
        {
            if (patchDoc == null)
            {
                return BadRequest();
            }
            var publisher = _repository.GetPublisher(id);
            if (publisher == null)
            {
                return NotFound();
            }
            var publisherDTO = Mapper.Map<PublisherInsertDTO>(publisher);
            patchDoc.ApplyTo(publisherDTO,ModelState);
            Mapper.Map(publisherDTO, publisher);
            if (!_repository.Save())
            {
                return StatusCode(500, "internal server error");
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult deletePublisher(int id)
        {
            var publisher = _repository.GetPublisher(id);
            if (publisher == null)
            {
                return NotFound();
            }
            if (!_repository.Delete(publisher))
            {
                return StatusCode(500, "internal server error");
            }
            return NoContent();
        }
    }
}
