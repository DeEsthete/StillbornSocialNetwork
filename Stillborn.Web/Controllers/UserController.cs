using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Stillborn.Domain.Entities;
using Stillborn.Models.ViewModels;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Services;

namespace Stillborn.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;

        public UserController(UserManager<User> userManager, IUserService userService)
        {
            _userManager = userManager;
            _userService = userService;
        }

        [HttpPost("/login")]
        public async Task Login()
        {
            var model = new LoginUserViewModel
            {
                Login = Request.Form["username"],
                Password = Request.Form["password"]
            };

            var identity = await _userService.GetIdentityAsync(model);
            if (identity == null)
            {
                Response.StatusCode = 400;
                await Response.WriteAsync("Invalid username or password.");
                return;
            }

            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                access_token = encodedJwt,
                username = identity.Name
            };

            // сериализация ответа
            Response.ContentType = "application/json";
            await Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented }));
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