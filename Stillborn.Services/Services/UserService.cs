using Microsoft.AspNetCore.Identity;
using Stillborn.Domain.Entities;
using Stillborn.Models.ViewModels;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
            _repositoryService.GetRepository<Content>().Add(content);
        }

        /// <summary>
        /// create usercontact
        /// </summary>
        /// <param name="mainUserId"></param>
        /// <param name="secondUserId"></param>
        public async Task AddToBlockedAsync(string mainUserId, string secondUserId)
        {
            UserContact contact = new UserContact();
            contact.CreationDate = DateTime.UtcNow;
            contact.MainUser = await _userManager.FindByIdAsync(mainUserId);
            contact.SecondUser = await _userManager.FindByIdAsync(secondUserId);
            contact.Type = _repositoryService.GetRepository<ContactType>().FindById(3);
            _repositoryService.GetRepository<UserContact>().Add(contact);
        }

        public async Task AddToFriendAsync(string mainUserId, string secondUserId)
        {
            var user = await _userManager.FindByIdAsync(mainUserId);
            var userContact = _repositoryService.GetRepository<UserContact>().GetAll().FirstOrDefault(c => c.MainUser == user);
            if(userContact != null)
            {
                userContact.Type = _repositoryService.GetRepository<ContactType>().FindById((int)ContactTypes.Friend);
                _repositoryService.GetRepository<UserContact>().Update(userContact);
            }
            else
            {
                UserContact contact = new UserContact();
                contact.CreationDate = DateTime.UtcNow;
                contact.MainUser = user;
                contact.SecondUser = await _userManager.FindByIdAsync(secondUserId);
                contact.Type = _repositoryService.GetRepository<ContactType>().FindById((int)ContactTypes.Friend);
                _repositoryService.GetRepository<UserContact>().Add(contact);
            }
        }

        public void Authorization(AuthorizationUserViewModel user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetBlockedUsersAsync(string userid)
        {
            List<User> blockedUsers = new List<User>();
           var userContacts = _repositoryService.GetRepository<UserContact>().
                GetAll().Where(c => c.MainUserId == userid && c.TypeId == (int)ContactTypes.Blocked);
            foreach(var uc in userContacts)
            {
                blockedUsers.Add(await _userManager.FindByIdAsync(uc.SecondUserId));
            }
            return blockedUsers;
        }

        public Content GetUserContent(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetFriendsAsync(string userid)
        {
            List<User> friendUsers = new List<User>();
            var userContacts = _repositoryService.GetRepository<UserContact>().
                GetAll().Where(c => c.MainUserId == userid && c.TypeId == (int)ContactTypes.Friend);
            foreach (var uc in userContacts)
            {
                friendUsers.Add(await _userManager.FindByIdAsync(uc.SecondUserId));
            }
            return friendUsers;
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
