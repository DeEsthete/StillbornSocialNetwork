using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stillborn.Domain.Data;
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
                try
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                    var repositoryService = scope.ServiceProvider.GetRequiredService<Repositories.RepositoryService>();
                    var context = scope.ServiceProvider.GetRequiredService<StillbornContext>();

                    string[] ids = new string[4];
                    //*****
                    var firstWall = new Wall { CreationDate = GetCreationDateTime() };
                    var secondWall = new Wall { CreationDate = GetCreationDateTime() };
                    var thirdWall = new Wall { CreationDate = GetCreationDateTime() };
                    //******
                    var firstContent = new Content { CreationDate = GetCreationDateTime() };
                    var secondContent = new Content { CreationDate = GetCreationDateTime() };
                    var thirdContent = new Content { CreationDate = GetCreationDateTime() };
                    var fourthContent = new Content { CreationDate = GetCreationDateTime() };

                    context.Walls.AddRange(firstWall, secondWall, thirdWall);
                    context.Content.AddRange(firstContent, secondContent, thirdContent, fourthContent);
                    context.SaveChanges();

                    var user = new User { UserName = $"User0", Email = $"user0@gmail.com", WallId = firstWall.Id, ContentId = firstContent.Id };
                    await userManager.CreateAsync(user, "12345678aB");
                    ids[0] = user.Id;

                    var user1 = new User { UserName = $"User1", Email = $"user1@gmail.com", WallId = secondWall.Id, ContentId = thirdContent.Id };
                    await userManager.CreateAsync(user1, "12345678aB");
                    ids[1] = user1.Id;

                    var user2 = new User { UserName = $"User2", Email = $"user2@gmail.com", WallId = thirdWall.Id, ContentId = firstContent.Id };
                    await userManager.CreateAsync(user2, "12345678aB");
                    ids[2] = user2.Id;

                    var user3 = new User { UserName = $"User3", Email = $"user3@gmail.com", WallId = secondWall.Id, ContentId = secondContent.Id };
                    await userManager.CreateAsync(user3, "12345678aB");
                    ids[3] = user3.Id;
                    context.SaveChanges();

                    //*****
                    var firstMedia = new Media { ContentId = firstContent.Id, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 1, Likes = 2 };
                    var secondMedia = new Media { ContentId = secondContent.Id, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 2, Likes = 2 };
                    var thirdMedia = new Media { ContentId = secondContent.Id, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 3, Likes = 2 };
                    var fourthMedia = new Media { ContentId = thirdContent.Id, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 3, Likes = 2 };
                    context.AddRange(firstMedia, secondMedia, thirdMedia, fourthMedia);
                    context.SaveChanges();
                    //*****
                    var firstPost = new Post { WallId = firstWall.Id, CreationDate = GetCreationDateTime(), Text = "First Post", Likes = 1, ContentId = firstContent.Id };
                    var secondPost = new Post { WallId = secondWall.Id, CreationDate = GetCreationDateTime(), Text = "Second Post", Likes = 5, ContentId = secondContent.Id };
                    var thirdPost = new Post { WallId = thirdWall.Id, CreationDate = GetCreationDateTime(), Text = "Third Post", Likes = 7, ContentId = thirdContent.Id };
                    context.AddRange(firstPost, secondPost, thirdPost);
                    context.SaveChanges();
                    //******
                    var firstComment = new Comment() { PostId = firstPost.Id, MediaId = 2, ContentId = firstContent.Id, CreationDate = GetCreationDateTime(), Text = "First Comment", Likes = 1, SenderId = ids[0] };
                    var secondComment = new Comment() { PostId = secondPost.Id, MediaId = 1, ContentId = secondContent.Id, CreationDate = GetCreationDateTime(), Text = "Second Comment", Likes = 4, SenderId = ids[1] };
                    var thirdComment = new Comment() { PostId = thirdPost.Id, MediaId = 1, ContentId = thirdContent.Id, CreationDate = GetCreationDateTime(), Text = "Third Comment", Likes = 6, SenderId = ids[2] };
                    var fourthComment = new Comment() { PostId = firstPost.Id, MediaId = 3, ContentId = fourthContent.Id, CreationDate = GetCreationDateTime(), Text = "Forth Comment", Likes = 3, SenderId = ids[3] };
                    context.AddRange(
                        firstComment,
                        secondComment,
                        thirdComment,
                        fourthComment
                        );
                    context.SaveChanges();
                    //******
                    var firstChatRoom = new ChatRoom() { CreatorId = ids[2], CreationDate = GetCreationDateTime() };
                    var secondChatRoom = new ChatRoom() { CreatorId = ids[1], CreationDate = GetCreationDateTime() };
                    var thirdChatRoom = new ChatRoom() { CreatorId = ids[3], CreationDate = GetCreationDateTime() };
                    context.AddRange(
                        firstChatRoom,
                        secondChatRoom,
                        thirdChatRoom
                        );
                    context.SaveChanges();
                    //******
                    var firstMessage = new Message() { ChatRoomId = firstChatRoom.Id, SenderId = ids[0], Text = "First", ContentId = firstContent.Id, CreationDate = GetCreationDateTime() };
                    var secondMessage = new Message() { ChatRoomId = secondChatRoom.Id, SenderId = ids[1], Text = "second", ContentId = firstContent.Id, CreationDate = GetCreationDateTime() };
                    var thirdMessage = new Message() { ChatRoomId = firstChatRoom.Id, SenderId = ids[2], Text = "third", ContentId = secondContent.Id, CreationDate = GetCreationDateTime() };
                    context.AddRange(
                        firstMessage,
                        secondMessage,
                        thirdMessage
                        );
                    context.SaveChanges();
                    //*****
                    var firstGroup = new Group() { ContentId = firstContent.Id, WallId = firstWall.Id, CreationDate = GetCreationDateTime() };
                    var secondGroup = new Group() { ContentId = firstContent.Id, WallId = firstWall.Id, CreationDate = GetCreationDateTime() };
                    var thirdGroup = new Group() { ContentId = secondContent.Id, WallId = secondWall.Id, CreationDate = GetCreationDateTime() };
                    context.AddRange(
                         firstGroup,
                         secondGroup,
                         thirdGroup
                        );
                    context.SaveChanges();
                    //******
                    var firstMember = new Member() { CreationDate = GetCreationDateTime(), UserId = ids[0], GroupId = firstGroup.Id, RoleId = 1 };
                    var secondMember = new Member() { CreationDate = GetCreationDateTime(), UserId = ids[2], GroupId = secondGroup.Id, RoleId = 2 };
                    var thirdMember = new Member() { CreationDate = GetCreationDateTime(), UserId = ids[1], GroupId = secondGroup.Id, RoleId = 2 };
                    context.AddRange(
                        firstMember,
                        secondMember,
                        thirdMember
                        );
                    context.SaveChanges();
                    //*****
                    var firstUserChatRoom = new UserChatRoom() { CreationDate = GetCreationDateTime(), UserId = ids[1], ChatRoomId = firstChatRoom.Id };
                    var secondUserChatRoom = new UserChatRoom() { CreationDate = GetCreationDateTime(), UserId = ids[3], ChatRoomId = firstChatRoom.Id };
                    var thirdUserChatRoom = new UserChatRoom() { CreationDate = GetCreationDateTime(), UserId = ids[0], ChatRoomId = secondChatRoom.Id };
                    context.AddRange(
                        firstUserChatRoom,
                        secondUserChatRoom,
                        thirdUserChatRoom
                        );
                    context.SaveChanges();
                    //******
                    var firstUserContact = new UserContact() { CreationDate = GetCreationDateTime(), MainUserId = ids[0], SecondUserId = ids[1], TypeId = 1 };
                    var secondUserContact = new UserContact() { CreationDate = GetCreationDateTime(), MainUserId = ids[3], SecondUserId = ids[2], TypeId = 1 };
                    var thirdUserContact = new UserContact() { CreationDate = GetCreationDateTime(), MainUserId = ids[1], SecondUserId = ids[3], TypeId = 2 };
                    var fourthUserContact = new UserContact() { CreationDate = GetCreationDateTime(), MainUserId = ids[2], SecondUserId = ids[1], TypeId = 3 };
                    context.AddRange(
                       firstUserContact,
                       secondUserContact,
                       thirdUserContact,
                       fourthUserContact
                       );
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }
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
