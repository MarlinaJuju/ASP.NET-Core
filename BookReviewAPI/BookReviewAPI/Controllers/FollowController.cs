using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BookReviewAPI.Controllers
{
    public class FollowController:Controller
    {
        //private readonly IFollowerRepository _followerRepository;
        //private readonly IUserRepository _userRepository;
        //private readonly IAuthorRepository _authorRepository;
        //public FollowController(IFollowerRepository followerRepository, IUserRepository userRepository, IAuthorRepository authorRepository)
        //{
        //    _followerRepository = followerRepository;
        //    _userRepository = userRepository;
        //    _authorRepository = authorRepository;
        //}

        //[HttpPost("api/follow/user/{userId}/author/{authorId}")]
        //public IActionResult Follow(int userId, int authorId)
        //{
        //    var user = _userRepository.Get(userId);
        //    var author = _authorRepository.Get(authorId);
        //    if (user == null || author == null)
        //    {
        //        return NotFound();
        //    }
        //    var follow = _followerRepository.Get(userId, authorId);
        //    if (follow != null)
        //    {
        //        return Conflict();
        //    }
        //    Follower follower = new Follower
        //    {
        //        AuthorId = authorId,
        //        UserId = userId
        //    };
        //    if (!_followerRepository.AddSaveChanges(follower))
        //    {
        //        return StatusCode(500);
        //    }
        //    return NoContent();
        //}
    }
}
