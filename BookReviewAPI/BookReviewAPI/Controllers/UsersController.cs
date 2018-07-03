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
    [Route("api/user")]
    public class UsersController : Controller
    {
        //private readonly IUserRepository _userRepository;

        //public UsersController(IUserRepository repo)
        //{
        //    _userRepository = repo;
        //}

        //[HttpGet]
        //public IActionResult GetUsers()
        //{
        //    return Ok(Mapper.Map<List<UserProfileDTO>>(_userRepository.GetAll()));
        //}

        //[HttpGet("{id}", Name = "GetUser")]
        //public IActionResult GetUser(int id)
        //{
        //    var user = _userRepository.Get(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(Mapper.Map<UserProfileDetailDTO>(user));
        //}

        //[HttpPost]
        //public IActionResult AddUser([FromBody]UserDTO userDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var user = Mapper.Map<User>(userDto);
        //    if (!_userRepository.AddSaveChanges(user))
        //    {
        //        return StatusCode(500);
        //    }
        //    return CreatedAtRoute("GetUser", new { id = user.Id }, user);
        //}

        //[HttpPut("{id}")]
        //public IActionResult EditUser(int id, [FromBody]UserProfileDTO userProfile)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }
        //    var user = _userRepository.Get(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    Mapper.Map(userProfile, user);
        //    if (!_userRepository.Save())
        //    {
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}

        //[HttpPatch("{id}")]
        //public IActionResult PatchUser(int id, [FromBody]JsonPatchDocument<UserDTO> patchDoc)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }
        //    var user = _userRepository.Get(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    var userDto = Mapper.Map<UserDTO>(user);
        //    patchDoc.ApplyTo(userDto, ModelState);
        //    Mapper.Map(userDto, user);
        //    if (!_userRepository.Save())
        //    {
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteUser(int id)
        //{
        //    var user = _userRepository.Get(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    if (!_userRepository.RemoveSaveChanges(user))
        //    {
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}
    }
}
