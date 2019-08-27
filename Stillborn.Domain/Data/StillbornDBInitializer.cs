using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stillborn.Domain.Entities;
using System;

namespace Stillborn.Domain.Data
{
    public static class StillbornDBInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MediaType>().HasData(
                new MediaType() { Id = 1, Name = "Image", CreationDate = GetCreationDateTime() },
                new MediaType() { Id = 2, Name = "Music", CreationDate = GetCreationDateTime() },
                new MediaType() { Id = 3, Name = "Video", CreationDate = GetCreationDateTime() }
                //new MediaType() { Id = 4, Name = "Text", CreationDate = GetCreationDateTime() } // на случай если поменяем Text как Media
                );

            modelBuilder.Entity<ContactType>().HasData(
                new ContactType() { Id = 1, Name = "Friend", CreationDate=GetCreationDateTime() },
                new ContactType() { Id = 2, Name = "Follower", CreationDate=GetCreationDateTime() }
                );

            modelBuilder.Entity<GroupRole>().HasData(
                new GroupRole() { Id = 1, Name = "Admin", CreationDate = GetCreationDateTime() },
                new GroupRole() { Id = 2, Name = "Subscriber", CreationDate = GetCreationDateTime() }
                );

            //Остальное побочное добавим после реализации их добавления
            //**************
            //Content
            //Media
            //Wall
            //Post
            //Comment
            //ChatRoom
            //Message
            //Group
            //Member
            //UserChatRoom
            //UserContact
        }

        private static DateTime GetCreationDateTime()
        {
            Random random = new Random();
            int daysAgo = random.Next(-365*2, 0);
            var date = DateTime.UtcNow.AddDays(daysAgo);
            return date;
        }
    }
}
