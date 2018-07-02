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
    [Route("api/user")]
    public class UsersController : Controller
    {
        private readonly IBookReviewRepository _repository;

        public UsersController(IBookReviewRepository repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(Mapper.Map<List<UserProfileDTO>>(_repository.GetUsers()));
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetUser(int id)
        {
            var user = _repository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<UserProfileDetailDTO>(user));
        }

        [HttpPost]
        public IActionResult AddUser([FromBody]UserDTO userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = Mapper.Map<User>(userDto);
            if (!_repository.Add(user))
            {
                return StatusCode(500);
            }
            return CreatedAtRoute("GetUser", new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult EditUser(int id, [FromBody]UserProfileDTO userProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = _repository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            Mapper.Map(userProfile, user);
            if (!_repository.Save())
            {
                return StatusCode(500);
            }
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PatchUser(int id, [FromBody]JsonPatchDocument<UserDTO> patchDoc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = _repository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            var userDto = Mapper.Map<UserDTO>(user);
            patchDoc.ApplyTo(userDto, ModelState);
            Mapper.Map(userDto, user);
            if (!_repository.Save())
            {
                return StatusCode(500);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _repository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            if (!_repository.Delete(user))
            {
                return StatusCode(500);
            }
            return NoContent();
        }
    }
}
