using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Services
{
    public class ChatRoomService :IChatRoomService
    {
        private readonly RepositoryService _service;
        private readonly UserRepository _userContext = new UserRepository();
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
    }
}
