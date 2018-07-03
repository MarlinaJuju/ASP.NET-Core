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
    [Route("api/publisher")]
    public class PublishersController : Controller
    {
        //private readonly IPublisherRepository _publisherRepository;

        //public PublishersController(IPublisherRepository repo)
        //{
        //    _publisherRepository = repo;
        //}

        //[HttpGet]
        //public IActionResult GetPublishers()
        //{
        //    return Ok(Mapper.Map<IEnumerable<PublisherDTO>>(_publisherRepository.GetAll()));
        //}

        //[HttpGet("{id}", Name = "GetPublisher")]
        //public IActionResult GetPublisher(int id)
        //{
        //    var publisher = _publisherRepository.Get(id);
        //    if (publisher == null)
        //    {
        //        return NotFound();
        //    }
        //    var publisherDTO = Mapper.Map<PublisherDetailDTO>(publisher);
        //    return Ok(publisherDTO);
        //}

        //[HttpPost]
        //public IActionResult addPublisher([FromBody]PublisherInsertDTO publisherDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return StatusCode(BadRequest().StatusCode, ModelState.Values.First().Errors.First().ErrorMessage);
        //    }
        //    var publisher = Mapper.Map<Publisher>(publisherDTO);
        //    if (publisher == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (!_publisherRepository.AddSaveChanges(publisher))
        //    {
        //        return StatusCode(500, "internal server error");
        //    }
        //    return CreatedAtRoute("GetPublisher", new { id = publisher.Id }, publisher);
        //}

        //[HttpPut("{id}")]
        //public IActionResult editPublisher(int id, [FromBody] PublisherInsertDTO publisherDTO)
        //{
        //    if (publisherDTO == null)
        //    {
        //        return BadRequest();
        //    }
        //    var publisher = _publisherRepository.Get(id);
        //    if (publisher == null)
        //    {
        //        return NotFound();
        //    }
        //    Mapper.Map(publisherDTO, publisher);
        //    if (!_publisherRepository.Save())
        //    {
        //        return StatusCode(500, "internal server error");
        //    }
        //    return NoContent();
        //}

        //[HttpPatch("{id}")]
        //public IActionResult patchPublisher(int id, [FromBody]JsonPatchDocument<PublisherInsertDTO> patchDoc)
        //{
        //    if (patchDoc == null)
        //    {
        //        return BadRequest();
        //    }
        //    var publisher = _publisherRepository.Get(id);
        //    if (publisher == null)
        //    {
        //        return NotFound();
        //    }
        //    var publisherDTO = Mapper.Map<PublisherInsertDTO>(publisher);
        //    patchDoc.ApplyTo(publisherDTO,ModelState);
        //    Mapper.Map(publisherDTO, publisher);
        //    if (!_publisherRepository.Save())
        //    {
        //        return StatusCode(500, "internal server error");
        //    }
        //    return NoContent();
        //}
        //[HttpDelete("{id}")]
        //public IActionResult deletePublisher(int id)
        //{
        //    var publisher = _publisherRepository.Get(id);
        //    if (publisher == null)
        //    {
        //        return NotFound();
        //    }
        //    if (!_publisherRepository.RemoveSaveChanges(publisher))
        //    {
        //        return StatusCode(500, "internal server error");
        //    }
        //    return NoContent();
        //}
    }
}
