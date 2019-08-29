using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IChatRoomService
    {
        bool AddUserToChatRoom(string userId, int chatGroupId);
        bool LeaveChatRoom(string userId, int chatGroupId);
        bool CreateChatRoom(string creatorId, string name);
        bool DeleteChatRoom(int chatGroupId);
        IEnumerable<User> GetChatRoomUsers(int chatRoomId);
        IEnumerable<Message> GetChatRoomMessages(int chatRoomId);
        bool SendMessage(int senderId,int contentId);

    }
}
