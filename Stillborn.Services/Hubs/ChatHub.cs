using Microsoft.AspNetCore.SignalR;
using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stillborn.Services.Hubs
{
    public class ChatHub:Hub
    {
        public async Task Send(string senderId, int contentId, string text, int chatRoomId)
        {
            Message message = new Message();
            message.SenderId = senderId;
            message.Text = text;
            message.ContentId = contentId;
            message.ChatRoomId = chatRoomId;
            await Clients.All.SendAsync("Send", message);
        }
    }
}
