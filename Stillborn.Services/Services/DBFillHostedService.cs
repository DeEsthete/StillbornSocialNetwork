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
                    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                    foreach (var roleName in Enum.GetNames(typeof(BaseRoles)))
                    {
                        var roleExist = await roleManager.RoleExistsAsync(roleName);
                        if (!roleExist)
                        {
                            //create the roles and seed them to the database: Question 1
                            await roleManager.CreateAsync(new IdentityRole(roleName));
                        }
                    }

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
                    //***********
                    bool userCreated = false;

                    var user = await userManager.FindByNameAsync("User0");
                    if (user == null)
                    {
                        user = new User { UserName = "User0", Email = "user0@gmail.com", Wall = firstWall, Content = firstContent };
                        await userManager.CreateAsync(user, "12345678aB");
                        userCreated = true;
                    }

                    var user1 = await userManager.FindByNameAsync("User1");
                    if (user1 == null)
                    {
                        user1 = new User { UserName = "User1", Email = "user1@gmail.com", Wall = secondWall, Content = thirdContent };
                        await userManager.CreateAsync(user1, "12345678aB");
                        userCreated = true;
                    }

                    var user2 = await userManager.FindByNameAsync("User1");
                    if (user2 == null)
                    {
                        user2 = new User { UserName = "User2", Email = "user2@gmail.com", Wall = thirdWall, Content = firstContent };
                        await userManager.CreateAsync(user2, "12345678aB");
                        userCreated = true;
                    }

                    var user3 = await userManager.FindByNameAsync("User1");
                    if (user3 == null)
                    {

                        user3 = new User { UserName = "User3", Email = "user3@gmail.com", Wall = secondWall, Content = secondContent };
                        await userManager.CreateAsync(user3, "12345678aB");
                        userCreated = true;
                    }
                    if (userCreated == true) context.SaveChanges();

                    //*****
                    var firstMedia = new Media { Content = firstContent, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 1, Likes = 2 };
                    var secondMedia = new Media { Content = secondContent, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 2, Likes = 2 };
                    var thirdMedia = new Media { Content = secondContent, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 3, Likes = 2 };
                    var fourthMedia = new Media { Content = thirdContent, CreationDate = GetCreationDateTime(), Bytes = new byte[0], TypeId = 3, Likes = 2 };
                    context.AddRange(firstMedia, secondMedia, thirdMedia, fourthMedia);
                    context.SaveChanges();
                    //*****
                    var firstPost = new Post { Wall = firstWall, CreationDate = GetCreationDateTime(), Text = "First Post", Content = firstContent };
                    var secondPost = new Post { Wall = secondWall, CreationDate = GetCreationDateTime(), Text = "Second Post", Content = secondContent };
                    var thirdPost = new Post { Wall = thirdWall, CreationDate = GetCreationDateTime(), Text = "Third Post", Content = thirdContent };
                    context.AddRange(firstPost, secondPost, thirdPost);
                    context.SaveChanges();
                    //******
                    var firstComment = new Comment()
                    {
                        Post = firstPost,
                        MediaId = 2,
                        Content = firstContent,
                        CreationDate = GetCreationDateTime(),
                        Text = "First Comment",
                        Likes = 1,
                        Sender = user
                    };
                    var secondComment = new Comment() { Post = secondPost, MediaId = 1, Content = secondContent, CreationDate = GetCreationDateTime(), Text = "Second Comment", Likes = 4, Sender = user1 };
                    var thirdComment = new Comment() { Post = thirdPost, MediaId = 1, Content = thirdContent, CreationDate = GetCreationDateTime(), Text = "Third Comment", Likes = 6, Sender = user2 };
                    var fourthComment = new Comment() { Post = firstPost, MediaId = 3, Content = fourthContent, CreationDate = GetCreationDateTime(), Text = "Forth Comment", Likes = 3, Sender = user3 };
                    context.AddRange(
                        firstComment,
                        secondComment,
                        thirdComment,
                        fourthComment
                        );
                    context.SaveChanges();
                    //******
                    var firstChatRoom = new ChatRoom() { Creator = user2, CreationDate = GetCreationDateTime() };
                    var secondChatRoom = new ChatRoom() { Creator = user1, CreationDate = GetCreationDateTime() };
                    var thirdChatRoom = new ChatRoom() { Creator = user3, CreationDate = GetCreationDateTime() };
                    context.AddRange(
                        firstChatRoom,
                        secondChatRoom,
                        thirdChatRoom
                        );
                    context.SaveChanges();
                    //******
                    var firstMessage = new Message() { ChatRoom = firstChatRoom, Sender = user, Text = "First", Content = firstContent, CreationDate = GetCreationDateTime() };
                    var secondMessage = new Message() { ChatRoom = secondChatRoom, Sender = user1, Text = "second", Content = firstContent, CreationDate = GetCreationDateTime() };
                    var thirdMessage = new Message() { ChatRoom = firstChatRoom, Sender = user2, Text = "third", Content = secondContent, CreationDate = GetCreationDateTime() };
                    context.AddRange(
                        firstMessage,
                        secondMessage,
                        thirdMessage
                        );
                    context.SaveChanges();
                    //*****
                    var firstGroup = new Group() { Content = firstContent, Wall = firstWall, CreationDate = GetCreationDateTime() };
                    var secondGroup = new Group() { Content = firstContent, Wall = firstWall, CreationDate = GetCreationDateTime() };
                    var thirdGroup = new Group() { Content = secondContent, Wall = secondWall, CreationDate = GetCreationDateTime() };
                    context.AddRange(
                         firstGroup,
                         secondGroup,
                         thirdGroup
                        );
                    context.SaveChanges();
                    //******
                    var firstMember = new Member() { CreationDate = GetCreationDateTime(), User = user, Group = firstGroup, RoleId = 1 };
                    var secondMember = new Member() { CreationDate = GetCreationDateTime(), User = user2, Group = secondGroup, RoleId = 2 };
                    var thirdMember = new Member() { CreationDate = GetCreationDateTime(), User = user1, Group = secondGroup, RoleId = 2 };
                    context.AddRange(
                        firstMember,
                        secondMember,
                        thirdMember
                        );
                    context.SaveChanges();
                    //*****
                    var firstUserChatRoom = new UserChatRoom() { CreationDate = GetCreationDateTime(), User = user1, ChatRoom = firstChatRoom };
                    var secondUserChatRoom = new UserChatRoom() { CreationDate = GetCreationDateTime(), User = user3, ChatRoom = firstChatRoom };
                    var thirdUserChatRoom = new UserChatRoom() { CreationDate = GetCreationDateTime(), User = user2, ChatRoom = secondChatRoom };
                    context.AddRange(
                        firstUserChatRoom,
                        secondUserChatRoom,
                        thirdUserChatRoom
                        );
                    context.SaveChanges();
                    //******
                    var firstUserContact = new UserContact() { CreationDate = GetCreationDateTime(), MainUser = user, SecondUser = user1, TypeId = 1 };
                    var secondUserContact = new UserContact() { CreationDate = GetCreationDateTime(), MainUser = user3, SecondUser = user2, TypeId = 1 };
                    var thirdUserContact = new UserContact() { CreationDate = GetCreationDateTime(), MainUser = user1, SecondUser = user3, TypeId = 2 };
                    var fourthUserContact = new UserContact() { CreationDate = GetCreationDateTime(), MainUser = user2, SecondUser = user1, TypeId = 3 };
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
