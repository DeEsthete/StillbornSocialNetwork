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
    public class ChatRoomController : ControllerBase
    {
        private readonly IChatRoomService _chatRoomService;
        private readonly RepositoryService _repository;
        public ChatRoomController(IChatRoomService chatRoomService, RepositoryService repository)
        {
            _chatRoomService = chatRoomService;
            _repository = repository;
        }
        [HttpGet("{id}")]
        public IActionResult GetChatRoomById(int id)
        {
            return Ok(_repository.GetRepository<ChatRoom>().FindById(id));
        }
        [HttpGet("{id}")]
        public IActionResult GetUserChatRooms(string userId)
        {
            return Ok(_chatRoomService.GetUserChatRooms(userId));
        }
        [HttpGet("{id}")]
        public IActionResult GetChatRoomUsers(int chatId)
        {
            IEnumerable<string> userIdes = new List<string>();
            foreach(var i in _repository.GetRepository<ChatRoom>().FindById(chatId).Users.ToList())
            {
                userIdes.ToList().Add(i.UserId);
            }
            return Ok(userIdes);
        }
        //Add
        [HttpPost]
        public IActionResult Post(ChatRoom chatRoom)
        {
            if (ModelState.IsValid)
            {
                _repository.GetRepository<ChatRoom>().Add(chatRoom);
                return Ok();
            }
            return BadRequest();
        }

        //Обновить
        [HttpPut("{id}")]
        public IActionResult Put(ChatRoom chatRoom)
        {
            if (ModelState.IsValid)
            {
                _repository.GetRepository<ChatRoom>().Update(chatRoom);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetChatRoomLastMessage(int chatRoomId)
        {
            return Ok(_repository.GetRepository<ChatRoom>().FindById(chatRoomId).Messages.ToList().Last());
        }
    }
}