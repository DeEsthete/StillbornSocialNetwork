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
using Stillborn.Domain.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace Stillborn.Services.Services
{
    public class UserService : IUserService
    {
        private readonly RepositoryService _repositoryService;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(RepositoryService repositoryService, UserManager<User> userManager, SignInManager<User> signInManager )
        {
            _repositoryService = repositoryService;
            _userManager = userManager;
            _signInManager = signInManager;
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

        public async Task<IEnumerable<User>> GetBlockedUsersAsync(string userid)
        {
            List<User> blockedUsers = new List<User>();
            var userContacts = _repositoryService.GetRepository<UserContact>().
                GetAll().Where(c => c.MainUserId == userid && c.TypeId == (int)ContactTypes.Blocked);
            foreach(var userCOntact in userContacts)
            {
                blockedUsers.Add(await _userManager.FindByIdAsync(userCOntact.SecondUserId));
            }
            return blockedUsers;
        }

        public async Task<Content> GetUserContentAsync(string userid)
        {
            User user = await _userManager.FindByIdAsync(userid);
            return _repositoryService.GetRepository<Content>().FindById(user.ContentId);
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

        public async Task<Wall> GetUserWallAsync(string userid)
        {
            User user = await _userManager.FindByIdAsync(userid);
            return _repositoryService.GetRepository<Wall>().FindById(user.WallId);
        }

        public async Task SetUserInfoAsync(UserInfoViewModel info)
        {
            User user = await _userManager.FindByIdAsync(info.Id);
            user.Gender = info.Gender;
            user.NickName = info.NickName;
            await _userManager.UpdateAsync(user);
        }

        public async Task<UserInfoViewModel> GetUserInfoAsync(string userid)
        {
            User user = await _userManager.FindByIdAsync(userid);
            return new UserInfoViewModel { Id = user.Id, NickName = user.NickName, Gender = user.Gender };
        }

        public ClaimsIdentity GetIdentity(LoginUserViewModel model)
        {
            User user = _userManager.Users.FirstOrDefault(u => u.UserName == model.Login);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType,model.Login),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, model.Password)
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }
            // если пользователя не найдено
            return null;
        }

        public async Task Registration(RegistrationUserViewModel model)
        {
            if (model!=null)
            {
                Wall wall = new Wall { CreationDate =DateTime.UtcNow };
                _repositoryService.GetRepository<Wall>().Add(wall);
                var content = new Content { CreationDate = DateTime.UtcNow };
                _repositoryService.GetRepository<Content>().Add(content);
                User user = new User { Email = model.Email, UserName = model.Login,WallId=wall.Id,ContentId=content.Id,NickName=model.NickName,Gender=model.Gender };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);//не будет работать нужны токены
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
