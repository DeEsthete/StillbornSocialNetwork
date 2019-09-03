using Stillborn.Domain.Entities;
using Stillborn.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stillborn.Services.Interfaces
{
    public interface IUserService
    {
        UserInfoViewModel GetUserInfo(string id);
        void SetUserInfo(UserInfoViewModel info);
        IEnumerable<User> GetUserFriends(string id);
        //кто добавляет, кого добавляет
        void AddUserFriend(string mainUserId, string secondUserId);
        IEnumerable<User> GetUserBlackList(string id);
        //кто добавляет, кого добавляет
        Task AddToBlackListAsync(string mainUserId, string secondUserId);
        Wall GetUserWall(string id);
        Content GetUserContent(string id);
        void AddContent(Content content);
        void Authorization(AuthorizationUserViewModel user);
        void Registration(RegistrationUserViewModel user);
    }
}
