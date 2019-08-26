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
        public virtual DbSet<ContentType> ContentTypes { get; set; }//*
        public virtual DbSet<Media> Medias { get; set; }//* Путает понимание значения, лучше Content
        public virtual DbSet<Content> Contents { get; set; }//* это Media
        //*************
        public virtual DbSet<Wall> Walls { get; set; }//*
        public virtual DbSet<Post> Posts { get; set; }//* посты обычно должны знать у какого юзера находятся
        public virtual DbSet<Comment> Comments { get; set; }//* Text по идее тоже Media
        //*************
        public virtual DbSet<ChatRoom> ChatRooms { get; set; }//нужен UserId-
        public virtual DbSet<Message> Messages { get; set; }//ему не нужно знать в каком Chatroom -
        //*************
        public virtual DbSet<ContactType> ContactTypes { get; set; }//*
        public virtual DbSet<GroupRole> GroupRoles { get; set; }//*
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Member> Members { get; set; } // нужен UserId -
        
        public virtual DbSet<UserChatRoom> UserChatRooms { get; set; }//нужен UserId-
        public virtual DbSet<UserContact> UserContacts { get; set; }//нужен UserId-


        protected override void OnModelCreating(ModelBuilder builder)
        {
            using (StillbornDBInitializer initializer = new StillbornDBInitializer())
            {
                initializer.Seed(builder);
            }
        }
    }
}
