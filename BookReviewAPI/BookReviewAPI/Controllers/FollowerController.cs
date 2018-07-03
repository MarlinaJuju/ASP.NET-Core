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
    public class FollowerController : Controller
    {
        //private readonly IFollowerRepository _followerRepository;
        //private readonly IAuthorRepository _authorRepository;
        //public FollowerController(IFollowerRepository followerRepository, IAuthorRepository authorRepository)
        //{
        //    _followerRepository = followerRepository;
        //    _authorRepository = authorRepository;
        //}
        //[HttpGet("api/author/{authorId}/follower")]
        //[SwaggerOperation(Tags = new[] { "Authors" })]
        //public IActionResult GetAuthorFollower(int authorId)
        //{
        //    var author = _authorRepository.Get(authorId);
        //    if (author == null)
        //    {
        //        return NotFound();
        //    }
        //    var users = _followerRepository.GetFollowersByAuthorIdIncludeUser(authorId).Select(x => x.User).ToList();
        //    return Ok(Mapper.Map<List<UserFollowerDTO>>(users));
        //}
    }
}
