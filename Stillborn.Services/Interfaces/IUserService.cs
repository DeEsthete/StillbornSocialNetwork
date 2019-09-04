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
        void AddContent(Content content);
        Task AddToBlockedAsync(string mainUserId, string secondUserId);
        Task AddToFriendAsync(string mainUserId, string secondUserId);
        IEnumerable<User> GetFriendsAsync(string id);

        void SetUserInfo(UserInfoViewModel info);
        UserInfoViewModel GetUserInfo(string id);
        
        IEnumerable<User> GetBlockedUsersAsync(string id);
        Content GetUserContent(string id);
        Wall GetUserWall(string id);
        
        void Authorization(AuthorizationUserViewModel user);
        void Registration(RegistrationUserViewModel user);
    }
}
