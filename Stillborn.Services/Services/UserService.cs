using Microsoft.AspNetCore.Identity;
using Stillborn.Domain.Entities;
using Stillborn.Models.ViewModels;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stillborn.Services.Services
{
    public class UserService : IUserService
    {
        private readonly RepositoryService _repositoryService;
        private readonly UserManager<User> _userManager;

        public UserService(RepositoryService repositoryService, UserManager<User> userManager)
        {
            _repositoryService = repositoryService;
            _userManager = userManager;
        }

        public void AddContent(Content content)
        {
            _repositoryService.GetRepository<Content>().AddEntity(content);
        }

        /// <summary>
        /// create usercontact
        /// </summary>
        /// <param name="mainUserId"></param>
        /// <param name="secondUserId"></param>
        public async Task AddToBlackListAsync(string mainUserId, string secondUserId)
        {
            UserContact contact = new UserContact();
            contact.CreationDate = DateTime.UtcNow;
            contact.MainUser = await _userManager.FindByIdAsync(mainUserId);
            contact.SecondUser = await _userManager.FindByIdAsync(secondUserId);
            contact.Type = _repositoryService.GetRepository<ContactType>().GetEntity(3);
            _repositoryService.GetRepository<UserContact>().AddEntity(contact);
        }

        public void AddUserFriend(string mainUserId, string secondUserId)
        {
            throw new NotImplementedException();
        }

        public void Authorization(AuthorizationUserViewModel user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUserBlackList(string id)
        {
            throw new NotImplementedException();
        }

        public Content GetUserContent(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUserFriends(string id)
        {
            throw new NotImplementedException();
        }

        public UserInfoViewModel GetUserInfo(string id)
        {
            throw new NotImplementedException();
        }

        public Wall GetUserWall(string id)
        {
            throw new NotImplementedException();
        }

        public void Registration(RegistrationUserViewModel user)
        {
            throw new NotImplementedException();
        }

        public void SetUserInfo(UserInfoViewModel info)
        {
            throw new NotImplementedException();
        }
    }
}
