using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IChatRoomService
    {
        void AddUserToChatRoom(string userId, int chatGroupId);
        void LeaveChatRoom(string userId, int chatGroupId);
        void CreateChatRoom(string creatorId, string name);
        IEnumerable<User> GetChatRoomUsers(int chatRoomId);
        IEnumerable<Message> GetChatRoomMessages(int chatRoomId);
        void SendMessage(int senderId,int contentId);

    }
}
