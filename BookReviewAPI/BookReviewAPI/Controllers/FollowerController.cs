using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviewAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookReviewAPI.Controllers
{
    [Route("Follower")]
    public class FollowerController : Controller
    {
        private readonly IBookReviewRepository _repository;
        public FollowerController(IBookReviewRepository repo)
        {
            _repository = repo;
        }
    }
}
