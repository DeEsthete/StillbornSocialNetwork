using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;

namespace Stillborn.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly RepositoryService _repository;
        public PostController(RepositoryService repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult GetPostById(int id)
        {
            return Ok(_repository.GetRepository<Post>().FindById(id));
        }

        [HttpGet]
        public IActionResult GetPosts()
        {
            return Ok(_repository.GetRepository<Post>().GetAll());
        }
        //Add
        [HttpPost]
        public IActionResult AddPost(Post post)
        {
            if (ModelState.IsValid)
            {
                _repository.GetRepository<Post>().Add(post);
                return Ok();
            }
            return BadRequest();
        }

        //Обновить
        [HttpPut]
        public IActionResult Put(Post post)
        {
            if (ModelState.IsValid)
            {
                _repository.GetRepository<Post>().Update(post);
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet("/getWallPosts/{id}")]
        public IActionResult GetPostsByWallId(int id)
        {
            return Ok(_repository.GetRepository<Post>().GetAll().Where(i=>i.WallId==id));
        }
    }
}