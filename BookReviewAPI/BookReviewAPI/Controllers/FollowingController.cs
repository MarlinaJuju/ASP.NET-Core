using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookReviewAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BookReviewAPI.Controllers
{
    public class FollowingController : Controller
    {
        //private readonly IFollowerRepository _followerRepository;
        //private readonly IUserRepository _userRepository;
        //public FollowingController(IFollowerRepository followerRepository, IUserRepository userRepository)
        //{
        //    _followerRepository = followerRepository;
        //    _userRepository = userRepository;
        //}
        //[HttpGet("api/user/{userId}/following")]
        //[SwaggerOperation(Tags =new[] {"Users" })]
        //public IActionResult GetFollowingAuthor(int userId)
        //{
        //    var user = _userRepository.Get(userId);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(Mapper.Map<List<AuthorFollowerDTO>>(_followerRepository.GetFollowersByUserIdIncludeAuthor(userId).Select(x=>x.Author).ToList()));
        //}
    }
}
