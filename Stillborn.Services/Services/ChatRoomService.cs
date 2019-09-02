using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

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
            ChatRoom chatRoom = _service.GetRepository<ChatRoom>().GetEntity(chatGroupId);
            User user= _service.GetRepository<User>().GetEntity(userId);
        }

        public void CreateChatRoom(string creatorId)
        {
            ChatRoom chatRoom = new ChatRoom();
            chatRoom.CreatorId = creatorId;
            _service.GetRepository<ChatRoom>().AddEntity(chatRoom);

        }

        public IEnumerable<Message> GetChatRoomMessages(int chatRoomId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetChatRoomUsers(int chatRoomId)
        {
            throw new NotImplementedException();
        }

        public void LeaveChatRoom(string userId, int chatGroupId)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(int senderId, int contentId)
        {
            throw new NotImplementedException();
        }
    }
}
