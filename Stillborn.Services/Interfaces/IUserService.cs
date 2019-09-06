using Stillborn.Domain.Entities;
using Stillborn.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Stillborn.Services.Interfaces
{
    public interface IUserService
    {
        void AddContent(Content content);
        Task AddToBlockedAsync(string mainUserId, string secondUserId);
        Task AddToFriendAsync(string mainUserId, string secondUserId);
        Task<IEnumerable<User>> GetFriendsAsync(string id);
        ClaimsIdentity GetIdentity(LoginUserViewModel model);
        Task SetUserInfoAsync(UserInfoViewModel info);
        Task<UserInfoViewModel> GetUserInfoAsync(string id);

        Task<IEnumerable<User>> GetBlockedUsersAsync(string id);
        Task<Content> GetUserContentAsync(string id);
        Task<Wall> GetUserWallAsync(string id);
        Task Registration(RegistrationUserViewModel model);
    }
}
