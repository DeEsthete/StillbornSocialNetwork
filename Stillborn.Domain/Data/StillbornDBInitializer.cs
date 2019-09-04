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
                new MediaType() { Id = (int)MediaTypes.Image, Name = MediaTypes.Image.ToString(), CreationDate = GetCreationDateTime() },
                new MediaType() { Id = (int)MediaTypes.Music, Name = MediaTypes.Music.ToString(), CreationDate = GetCreationDateTime() },
                new MediaType() { Id = (int)MediaTypes.Video, Name = MediaTypes.Video.ToString(), CreationDate = GetCreationDateTime() }
                //new MediaType() { Id = 4, Name = "Text", CreationDate = GetCreationDateTime() } // на случай если поменяем Text как Media
                );

            modelBuilder.Entity<ContactType>().HasData(
                new ContactType() { Id = (int)ContactTypes.Friend, Name = ContactTypes.Friend.ToString(), CreationDate = GetCreationDateTime() },
                new ContactType() { Id = (int)ContactTypes.Follower, Name = ContactTypes.Follower.ToString(), CreationDate = GetCreationDateTime() },
                new ContactType() { Id = (int)ContactTypes.Blocked, Name = ContactTypes.Blocked.ToString(), CreationDate = GetCreationDateTime() }
                );

            modelBuilder.Entity<GroupRole>().HasData(
                new GroupRole() { Id = (int)GroupRoles.Admin, Name = GroupRoles.Admin.ToString(), CreationDate = GetCreationDateTime() },
                new GroupRole() { Id = (int)GroupRoles.Subscriber, Name = GroupRoles.Subscriber.ToString(), CreationDate = GetCreationDateTime() }
                );

        }

        private static DateTime GetCreationDateTime()
        {
            Random random = new Random();
            int daysAgo = random.Next(-365 * 2, 0);
            var date = DateTime.UtcNow.AddDays(daysAgo);
            return date;
        }
    }
}
