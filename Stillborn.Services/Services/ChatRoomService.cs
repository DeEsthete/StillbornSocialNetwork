using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stillborn.Services.Services
{
    public class ChatRoomService : IChatRoomService
    {
        private readonly RepositoryService _service;

        public ChatRoomService(RepositoryService service)
        {
            _service = service;
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

        public IEnumerable<User> GetChatRoomUsers(int chatRoomId)
        {
            return _service.GetRepository<ChatRoom>().GetEntity(chatRoomId).Users.Select(u => u.User).ToList();
        }

        public IEnumerable<ChatRoom> GetUserChatRooms(string userId)
        {
            IEnumerable<UserChatRoom> userChatRooms = _service.GetRepository<UserChatRoom>().GetAll().Where(i => i.UserId == userId);
            List<ChatRoom> chatRooms = new List<ChatRoom>();
            foreach (var userChatRoom in userChatRooms)
            {
                chatRooms.Add(_service.GetRepository<ChatRoom>().GetEntity(userChatRoom.ChatRoomId));
            }
            return chatRooms;
        }

        public void LeaveChatRoom(string userId, int chatGroupId)
        {
            foreach (UserChatRoom userChat in _service.GetRepository<UserChatRoom>().GetAll())
            {
                if (userChat.UserId == userId && userChat.ChatRoomId == chatGroupId)
                {
                    _service.GetRepository<UserChatRoom>().RemoveEntity(userChat.Id);
                }
            }
        }
    }
}
