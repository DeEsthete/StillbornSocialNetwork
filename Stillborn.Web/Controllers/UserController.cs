using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stillborn.Domain.Entities;

namespace Stillborn.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;

        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }



        ////отдать
        //[HttpGet("{id}")]
        //public IActionResult Get(string id = null)
        //{
        //}

        //[HttpGet]
        //public IActionResult GetFriendsCount()
        //{
        //}

        //[HttpGet]
        //public IActionResult GetFollowersCount()
        //{
        //}

        //[HttpGet]
        //public IActionResult GetFriends()
        //{
        //}

        //[HttpGet]
        //public IActionResult GetBlockUsers()
        //{
        //}

        //[HttpGet]
        //public IActionResult GetFollowers()
        //{
        //}

        ////Добавить
        //[HttpPost]
        //public IActionResult Post([FromBody]User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _userManager.CreateAsync(user);
        //        return Ok();
        //    }
        //    return BadRequest();
        //}

        ////Обновить
        //[HttpPut("{id}")]
        //public IActionResult Put([FromBody]User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _userManager.UpdateAsync(user);
        //        return Ok();
        //    }
        //    return BadRequest();
        //}


    }
}