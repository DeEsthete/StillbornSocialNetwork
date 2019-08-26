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
            this._userManager = userManager;
        }

        //Отдать
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return Ok(_userManager.Users.ToList());
            }
            else
            {
                return Ok(_userManager.FindByIdAsync(id));
            }
        }

        //Добавить
        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            if (ModelState.IsValid)
            {
                _userManager.CreateAsync(user);
                return Ok();
            }
            return BadRequest();
        }

        //Обновить
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]User user)
        {
            if (ModelState.IsValid)
            {
                _userManager.UpdateAsync(user);
                return Ok();
            }
            return BadRequest();
        }
    }
}