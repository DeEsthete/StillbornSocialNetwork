using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stillborn.Services.Services
{
    public class ChatRoomService :Hub,IChatRoomService
    {
        private readonly RepositoryService _service;
        private readonly UserManager<User> _userManager;

        public ChatRoomService(RepositoryService service, UserManager<User> userManager)
        {
            _service = service;
            _userManager = userManager;
        }
        public void AddUserToChatRoom(string userId, int chatGroupId)
        {
            UserChatRoom userChatRoom = new UserChatRoom();
            userChatRoom.ChatRoomId = chatGroupId;
            userChatRoom.UserId = userId;
            _service.GetRepository<UserChatRoom>().AddEntity(userChatRoom);
        }

        public void CreateChatRoom(string creatorId)
        {
            ChatRoom chatRoom = new ChatRoom();
            chatRoom.CreatorId = creatorId;
            _service.GetRepository<ChatRoom>().AddEntity(chatRoom);

        }

        public async Task<IEnumerable<User>> GetChatRoomUsersAsync(int chatRoomId)
        {
            List<User> users = new List<User>();
            foreach(UserChatRoom user in _service.GetRepository<ChatRoom>().GetEntity(chatRoomId).Users)
            {
                users.Add( await _userManager.FindByIdAsync(user.UserId));
            }
            return users;
        }

        public void LeaveChatRoom(string userId, int chatGroupId)
        {
            foreach(UserChatRoom userChat in _service.GetRepository<UserChatRoom>().GetAll())
            {
                if (userChat.UserId == userId && userChat.ChatRoomId == chatGroupId)
                {
                    _service.GetRepository<UserChatRoom>().RemoveEntity(userChat.Id);
                }
            }
        }

        public async Task Send(string senderId, int contentId,string text)
        {
            Message message = new Message();
            message.SenderId = senderId;
            message.Text = text;
            message.ContentId = contentId;
            //Чат рум где задавать
            await this.Clients.All.SendAsync("Send", message);
        }
    }
}
