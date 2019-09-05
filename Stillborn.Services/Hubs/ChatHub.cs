using Microsoft.AspNetCore.SignalR;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stillborn.Services.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IChatRoomService _chatRoomService;
        private readonly RepositoryService _repository;

        public ChatHub(IChatRoomService chatRoomService, RepositoryService repository)
        {
            _chatRoomService = chatRoomService;
            _repository = repository;
        }
        public async Task Send(string senderId, int? contentId, string text, int chatRoomId)
        {
            Message message = new Message();
            message.SenderId = senderId;
            message.Text = text;
            message.ContentId = contentId;
            message.ChatRoomId = chatRoomId;
            _repository.GetRepository<Message>().Add(message);
            IEnumerable<string> sender=new List<string>();
            sender.ToList().Add(senderId);
            await Clients.Users(_chatRoomService.GetChatRoomUsers(chatRoomId).Select(u =>u.Id ).Except(sender).ToList()).SendAsync("Send", message);
        }
    }
}
