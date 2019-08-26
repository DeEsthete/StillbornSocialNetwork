using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stillborn.Domain.Entities;

namespace Stillborn.Domain.Data
{
    public class StillbornContext : IdentityDbContext<User>
    {
        public StillbornContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StillbornDb;Trusted_Connection=True;");
        }
        //сортировано по иерархии вложенности
        public DbSet<MediaType> MediaTypes { get; set; }//*
        public DbSet<Content> Content { get; set; }//* Путает понимание значения, лучше Content
        public DbSet<Media> Media { get; set; }//* это Media
        //*************
        public DbSet<Wall> Walls { get; set; }//*
        public DbSet<Post> Posts { get; set; }//* посты обычно должны знать у какого юзера находятся
        public DbSet<Comment> Comments { get; set; }//* Text по идее тоже Media
        //*************
        public DbSet<ChatRoom> ChatRooms { get; set; }//нужен UserId-
        public DbSet<Message> Messages { get; set; }//ему не нужно знать в каком Chatroom -
        //*************
        public DbSet<ContactType> ContactTypes { get; set; }//*
        public DbSet<GroupRole> GroupRoles { get; set; }//*
        public DbSet<Group> Groups { get; set; }
        public DbSet<Member> Members { get; set; } // нужен UserId -

        public DbSet<UserChatRoom> UserChatRooms { get; set; }//нужен UserId-
        public DbSet<UserContact> UserContacts { get; set; }//нужен UserId-


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }
    }
}
