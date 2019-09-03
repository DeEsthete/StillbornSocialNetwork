using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stillborn.Services.Interfaces
{
    public interface IChatRoomService
    {
        void AddUserToChatRoom(string userId, int chatGroupId);
        void LeaveChatRoom(string userId, int chatGroupId);
        void CreateChatRoom(string creatorId);
        IEnumerable<User> GetChatRoomUsers(int chatRoomId);
        Task Send(string senderId,int contentId,string text);

    }
}
