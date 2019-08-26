using Microsoft.EntityFrameworkCore;
using Stillborn.Domain.Entities;
using System;

namespace Stillborn.Domain.Data
{
    public static class StillbornDBInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContentType>().HasData(
                new ContentType() { Id = 1, Name = "Image", CreationDate = GetRandomCreationDateTime() },
                new ContentType() { Id = 2, Name = "Music", CreationDate = GetRandomCreationDateTime() },
                new ContentType() { Id = 3, Name = "Video", CreationDate = GetRandomCreationDateTime() },
                new ContentType() { Id = 4, Name = "Text", CreationDate = GetRandomCreationDateTime() }
                );

            modelBuilder.Entity<Media>().HasData(
                new Media() { Id = 1, CreationDate = GetRandomCreationDateTime() },
                new Media() { Id = 2, CreationDate = GetRandomCreationDateTime() },
                new Media() { Id = 3, CreationDate = GetRandomCreationDateTime() },
                new Media() { Id = 4, CreationDate = GetRandomCreationDateTime() }
                );

            //лучше вместо имени Content использовать Media
            modelBuilder.Entity<Content>().HasData(
                new Content() { MediaId = 1, CreationDate = GetRandomCreationDateTime(), Likes = 2, TypeId = 1 },
                new Content() {  MediaId = 2, CreationDate = GetRandomCreationDateTime(), Likes = 3, TypeId = 2 },
                new Content() {  MediaId = 3, CreationDate = GetRandomCreationDateTime(), Likes = 4, TypeId = 3 }
                );
            //**************
            modelBuilder.Entity<Wall>().HasData(
                new Wall() { Id = 1, CreationDate = GetRandomCreationDateTime() },
                new Wall() { Id = 2, CreationDate = GetRandomCreationDateTime() },
                new Wall() { Id = 3, CreationDate = GetRandomCreationDateTime() }
                );

            modelBuilder.Entity<Post>().HasData(
                new Post() { Id=1, WallId = 1, CreationDate = GetRandomCreationDateTime(), Text = "First Post", Likes = 1},
                new Post() { Id=2, WallId =1, CreationDate = GetRandomCreationDateTime(), Text = "Second Post", Likes = 15},
                new Post() { Id=3, WallId = 3, CreationDate = GetRandomCreationDateTime(), Text = "Third Post", Likes = 1}
                );

            modelBuilder.Entity<Comment>().HasData(
                new Comment() { Id =1, ContentId = 1, CreationDate = GetRandomCreationDateTime(), Text = "First Comment", Likes = 1},
                new Comment() {  Id =2, ContentId = 3, CreationDate = GetRandomCreationDateTime(), Text = "Second Comment", Likes = 1},
                new Comment() {  Id =3, ContentId = 2, CreationDate = GetRandomCreationDateTime(), Text = "Third Comment", Likes = 1}
                );
            //************************* Не передать UserId лучше в ходе работы добавить, после добавления User-ов
            //modelBuilder.Entity<ChatRoom>().HasData(
            //    new ChatRoom() { Id = 1, CreationDate = GetRandomCreationDateTime() },
            //    new ChatRoom() { Id = 2, CreationDate = GetRandomCreationDateTime() }
            //    );

            //modelBuilder.Entity<Message>().HasData(
            //    new Message() { Id = 1, CreationDate = GetRandomCreationDateTime() },
            //    new Message() { Id = 2, CreationDate = GetRandomCreationDateTime() },
            //    new Message() { Id = 3, CreationDate = GetRandomCreationDateTime() },
            //    new Message() { Id = 4, CreationDate = GetRandomCreationDateTime() }
            //    );

            modelBuilder.Entity<ContactType>().HasData(
                new ContactType() { Name = "Friend", },
                new ContactType() { Name = "Follower", }
                );

            modelBuilder.Entity<GroupRole>().HasData(
                new GroupRole() { Name = "Admin", CreationDate = GetRandomCreationDateTime() },
                new GroupRole() { Name = "Subscriber", CreationDate = GetRandomCreationDateTime() }
                );


        }

        private DateTime GetRandomCreationDateTime()
        {
            Random random = new Random();

            return DateTime.UtcNow.Date.AddDays(-random.Next(-365, 0));
        }
    }
}
