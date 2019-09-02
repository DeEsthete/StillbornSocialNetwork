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
        void SetUserInfo(UserInfoViewModel info);
        IEnumerable<User> GetUserFriends(string id);
        //кто добавляет, кого добавляет
        void AddUserFrind(string mainUserId, string secondUserId);
        IEnumerable<User> GetUserBlackList(string id);
        //кто добавляет, кого добавляет
        void AddUserBlackList(string mainUserId, string secondUserId);
        Wall GetUserWall(string id);
        Content GetUserContent(string id);
        void AddContent(Content content);
        void Authorization(AuthorizationUserViewModel user);
        void Registration(RegistrationUserViewModel user);
    }
}
