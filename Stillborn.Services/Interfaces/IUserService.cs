using Stillborn.Domain.Entities;
using Stillborn.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IUserService
    {
        UserInfoViewModel GetUserInfo(string id);
        bool SetUserInfo(UserInfoViewModel info);
        IEnumerable<User> GetUserFriends(string id);
        //кто добавляет, кого добавляет
        bool AddUserFrind(string mainUserId, string secondUserId);
        IEnumerable<User> GetUserBlackList(string id);
        //кто добавляет, кого добавляет
        bool AddUserBlackList(string mainUserId, string secondUserId);
        Wall GetUserWall(string id);
        Content GetUserContent(string id);
        bool AddContent(Content content);
    }
}
