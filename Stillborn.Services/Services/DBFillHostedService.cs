using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IServiceProvider _serviceProvider;

        public DBFillHostedService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var userManager = (UserManager<User>)scope.ServiceProvider.GetRequiredService(typeof(UserManager<User>));
                var repositoryService = (Repositories.RepositoryService)scope.ServiceProvider.GetRequiredService(typeof(Repositories.RepositoryService));

                var quantity = 4;
                string[] ids = new string[quantity];
                for (int i = 0; i < quantity; i++)
                {
                    var user = new User { UserName = $"User{i}", Email = $"user{i}@gmail.com" };
                    await userManager.CreateAsync(user, "12345");
                    ids[i] = user.Id;
                }
                //*******
                repositoryService.GetRepository<Content>().AddEntity(
                    new Content { Id = 1, CreationDate = GetCreationDateTime() }
                    );
                repositoryService.GetRepository<Content>().AddEntity(
                    new Content { Id = 2, CreationDate = GetCreationDateTime() }
                    );
                repositoryService.GetRepository<Content>().AddEntity(
                    new Content { Id = 3, CreationDate = GetCreationDateTime() }
                    );
                repositoryService.GetRepository<Content>().AddEntity(
                    new Content { Id = 4, CreationDate = GetCreationDateTime() }
                    );
                //*****
                repositoryService.GetRepository<Media>().AddEntity(
                    new Media { Id = 1, ContentId = 1, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 1, Likes = 2 }
                    );
                repositoryService.GetRepository<Media>().AddEntity(
                    new Media { Id = 2, ContentId = 2, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 2, Likes = 2 }
                    );
                repositoryService.GetRepository<Media>().AddEntity(
                    new Media { Id = 3, ContentId = 2, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 3, Likes = 2 }
                    );
                repositoryService.GetRepository<Media>().AddEntity(
                    new Media { Id = 4, ContentId = 3, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 3, Likes = 2 }
                    );
                //*****
                repositoryService.GetRepository<Wall>().AddEntity(
                    new Wall { Id = 1, CreationDate = GetCreationDateTime() }
                    );
                repositoryService.GetRepository<Wall>().AddEntity(
                    new Wall { Id = 2, CreationDate = GetCreationDateTime() }
                    );
                repositoryService.GetRepository<Wall>().AddEntity(
                    new Wall { Id = 3, CreationDate = GetCreationDateTime() }
                    );
                //******
                repositoryService.GetRepository<Post>().AddEntity(
                    new Post { Id = 1, WallId = 1, CreationDate = GetCreationDateTime(), Text = "First Post", Likes = 1, ContentId = 1 }
                    );
                repositoryService.GetRepository<Post>().AddEntity(
                   new Post { Id = 2, WallId = 2, CreationDate = GetCreationDateTime(), Text = "Second Post", Likes = 5, ContentId = 2 }
                   );
                repositoryService.GetRepository<Post>().AddEntity(
                   new Post { Id = 3, WallId = 3, CreationDate = GetCreationDateTime(), Text = "Third Post", Likes = 7, ContentId = 3 }
                   );
                //******
                repositoryService.GetRepository<Comment>().AddEntity(
                    new Comment() { Id = 1, PostId = 1, MediaId = 2, ContentId = 1, CreationDate = GetCreationDateTime(), Text = "First Comment", Likes = 1, SenderId = ids[0] }
                   );
                repositoryService.GetRepository<Comment>().AddEntity(
                    new Comment() { Id = 1, PostId = 2, MediaId = 1, ContentId = 2, CreationDate = GetCreationDateTime(), Text = "Second Comment", Likes = 4, SenderId = ids[0] }
                   );
                repositoryService.GetRepository<Comment>().AddEntity(
                    new Comment() { Id = 1, PostId = 3, MediaId = 1, ContentId = 3, CreationDate = GetCreationDateTime(), Text = "Third Comment", Likes = 6, SenderId = ids[1] }
                   );
                repositoryService.GetRepository<Comment>().AddEntity(
                    new Comment() { Id = 1, PostId = 1, MediaId = 3, ContentId = 4, CreationDate = GetCreationDateTime(), Text = "Forth Comment", Likes = 3, SenderId = ids[2] }
                   );
                //******
                repositoryService.GetRepository<ChatRoom>().AddEntity(
                    new ChatRoom() { Id = 1, CreatorId=ids[2], CreationDate = GetCreationDateTime() }
                   );
                repositoryService.GetRepository<ChatRoom>().AddEntity(
                    new ChatRoom() { Id = 2, CreatorId = ids[1], CreationDate = GetCreationDateTime() }
                   );
                repositoryService.GetRepository<ChatRoom>().AddEntity(
                    new ChatRoom() { Id = 3, CreatorId = ids[3], CreationDate = GetCreationDateTime() }
                   );
                //******
                repositoryService.GetRepository<Message>().AddEntity(
                    new Message() { Id = 1, ChatRoomId=1, SenderId=ids[0], Text="First", ContentId=1, CreationDate = GetCreationDateTime() }
                   );
                repositoryService.GetRepository<Message>().AddEntity(
                    new Message() { Id = 2, ChatRoomId = 2, SenderId = ids[1], Text = "second", ContentId = 1, CreationDate = GetCreationDateTime() }
                   );
                repositoryService.GetRepository<Message>().AddEntity(
                    new Message() { Id = 3, ChatRoomId = 1, SenderId = ids[2], Text = "third", ContentId = 1, CreationDate = GetCreationDateTime() }
                   );
                //*****
                repositoryService.GetRepository<Group>().AddEntity(
                    new Group() { Id = 1, ContentId = 1, WallId=1, CreationDate = GetCreationDateTime() }
                   );
                repositoryService.GetRepository<Group>().AddEntity(
                    new Group() { Id = 2, ContentId = 1, WallId = 1, CreationDate = GetCreationDateTime() }
                   );
                repositoryService.GetRepository<Group>().AddEntity(
                    new Group() { Id = 3, ContentId = 2, WallId = 1, CreationDate = GetCreationDateTime() }
                   );
                //******
                repositoryService.GetRepository<Member>().AddEntity(
                   new Member() { Id = 1, CreationDate = GetCreationDateTime(), UserId=ids[0], GroupId=1, RoleId=1 }
                  );
                repositoryService.GetRepository<Member>().AddEntity(
                   new Member() { Id = 2, CreationDate = GetCreationDateTime(), UserId = ids[2], GroupId = 1, RoleId = 2 }
                  );
                repositoryService.GetRepository<Member>().AddEntity(
                   new Member() { Id = 3, CreationDate = GetCreationDateTime(), UserId = ids[1], GroupId = 2, RoleId = 2 }
                  );
                //*****
                repositoryService.GetRepository<UserChatRoom>().AddEntity(
                   new UserChatRoom() { Id = 1, CreationDate = GetCreationDateTime(), UserId = ids[1], ChatRoomId=1 }
                  );
                repositoryService.GetRepository<UserChatRoom>().AddEntity(
                   new UserChatRoom() { Id =2, CreationDate = GetCreationDateTime(), UserId = ids[3], ChatRoomId = 1 }
                  );
                repositoryService.GetRepository<UserChatRoom>().AddEntity(
                   new UserChatRoom() { Id = 3, CreationDate = GetCreationDateTime(), UserId = ids[0], ChatRoomId = 2 }
                  );
                //******
                repositoryService.GetRepository<UserContact>().AddEntity(
                  new UserContact() { Id = 1, CreationDate = GetCreationDateTime(), MainUserId=ids[0], SecondUserId=ids[1], TypeId=1  }
                 );
                repositoryService.GetRepository<UserContact>().AddEntity(
                  new UserContact() { Id =2, CreationDate = GetCreationDateTime(), MainUserId = ids[0], SecondUserId = ids[1], TypeId = 1 }
                 );
                repositoryService.GetRepository<UserContact>().AddEntity(
                  new UserContact() { Id = 3, CreationDate = GetCreationDateTime(), MainUserId = ids[1], SecondUserId = ids[1], TypeId = 2 }
                 );
                repositoryService.GetRepository<UserContact>().AddEntity(
                  new UserContact() { Id = 4, CreationDate = GetCreationDateTime(), MainUserId = ids[2], SecondUserId = ids[1], TypeId = 3 }
                 );
            }

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
