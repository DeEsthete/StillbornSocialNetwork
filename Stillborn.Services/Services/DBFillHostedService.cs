using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stillborn.Services.Services
{
    public class DBFillHostedService : IHostedService
    {
        private readonly Repositories.RepositoryService _repositoryService;
        private readonly UserManager<User> _userManager;

        public DBFillHostedService(Repositories.RepositoryService repositoryService, UserManager<User> userManager)
        {
            _repositoryService = repositoryService;
            _userManager = userManager;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var quantity = 4;
            string[] ids = new string[quantity];
            for(int i=0; i<quantity;i++)
            {
                var user = new User { UserName = $"User{i}", Email = $"user{i}@gmail.com" };
                await _userManager.CreateAsync(user);
                ids[i] = user.Id;
            }
            //*******
            _repositoryService.GetRepository<Content>().AddEntity(
                new Content { Id = 1, CreationDate = GetCreationDateTime() }
                );
            _repositoryService.GetRepository<Content>().AddEntity(
                new Content { Id=2, CreationDate = GetCreationDateTime() }
                );
            _repositoryService.GetRepository<Content>().AddEntity(
                new Content { Id=3, CreationDate = GetCreationDateTime() }
                );
            _repositoryService.GetRepository<Content>().AddEntity(
                new Content { Id=4, CreationDate = GetCreationDateTime() }
                );
            //*****
            _repositoryService.GetRepository<Media>().AddEntity(
                new Media {Id = 1, ContentId=1, CreationDate = GetCreationDateTime(), Bytes=new byte[0], TypeId =  1, Likes=2 }
                );
            _repositoryService.GetRepository<Media>().AddEntity(
                new Media { Id = 2, ContentId = 2, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 2, Likes = 2 }
                );
            _repositoryService.GetRepository<Media>().AddEntity(
                new Media { Id = 3, ContentId = 2, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 3, Likes = 2 }
                );
            _repositoryService.GetRepository<Media>().AddEntity(
                new Media { Id = 4, ContentId = 3, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 3, Likes = 2 }
                );
            //*****
            _repositoryService.GetRepository<Wall>().AddEntity(
                new Wall { Id = 1, CreationDate = GetCreationDateTime() }
                );
            _repositoryService.GetRepository<Wall>().AddEntity(
                new Wall { Id = 2, CreationDate = GetCreationDateTime() }
                );
            _repositoryService.GetRepository<Wall>().AddEntity(
                new Wall { Id = 3, CreationDate = GetCreationDateTime() }
                );
            //******
            _repositoryService.GetRepository<Post>().AddEntity(
                new Post { Id = 1, WallId = 1, CreationDate = GetCreationDateTime(), Text = "First Post", Likes = 1, ContentId=1 }
                );
            _repositoryService.GetRepository<Post>().AddEntity(
               new Post { Id = 2, WallId = 2, CreationDate = GetCreationDateTime(), Text = "Second Post", Likes = 5, ContentId = 2}
               );
            _repositoryService.GetRepository<Post>().AddEntity(
               new Post { Id = 3, WallId = 3, CreationDate = GetCreationDateTime(), Text = "Third Post", Likes = 7, ContentId = 3 }
               );
            //******
            _repositoryService.GetRepository<Comment>().AddEntity(
                new Comment() { Id = 1, PostId=1, MediaId=2, ContentId = 1, CreationDate = GetCreationDateTime(), Text = "First Comment", Likes = 1, SenderId=ids[0]}
               );
            _repositoryService.GetRepository<Comment>().AddEntity(
                new Comment() { Id = 1, PostId = 2, MediaId = 1, ContentId = 2, CreationDate = GetCreationDateTime(), Text = "Second Comment", Likes = 4, SenderId = ids[0] }
               );
            _repositoryService.GetRepository<Comment>().AddEntity(
                new Comment() { Id = 1, PostId = 3, MediaId = 1, ContentId = 3, CreationDate = GetCreationDateTime(), Text = "Third Comment", Likes = 6, SenderId = ids[1] }
               );
            _repositoryService.GetRepository<Comment>().AddEntity(
                new Comment() { Id = 1, PostId = 1, MediaId = 3, ContentId = 4, CreationDate = GetCreationDateTime(), Text = "Forth Comment", Likes = 3, SenderId = ids[2] }
               );
            //******

        }

        private DateTime GetCreationDateTime()
        {
            Random random = new Random();
            int daysAgo = random.Next(-365 * 2, 0);
            var date = DateTime.UtcNow.AddDays(daysAgo);
            return date;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
