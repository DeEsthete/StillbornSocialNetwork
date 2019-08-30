using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stillborn.Domain.Entities;

namespace Stillborn.Domain.Data
{
    public class StillbornContext : IdentityDbContext<User>
    {
        public StillbornContext()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch
            {
                Database.ExecuteSqlCommand("DROP DATABASE StillbornDb");
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StillbornDb;Trusted_Connection=True;");
        }
        //сортировано по иерархии вложенности
        public DbSet<MediaType> MediaTypes { get; set; }//**
        public DbSet<Content> Content { get; set; }//**
        public DbSet<Media> Media { get; set; }//**
        //*************
        public DbSet<Wall> Walls { get; set; }//**
        public DbSet<Post> Posts { get; set; }//**
        public DbSet<Comment> Comments { get; set; }//**
        //*************
        public DbSet<ChatRoom> ChatRooms { get; set; }
        public DbSet<Message> Messages { get; set; }
        //*************
        public DbSet<ContactType> ContactTypes { get; set; }//**
        public DbSet<GroupRole> GroupRoles { get; set; }//**
        public DbSet<Group> Groups { get; set; }
        public DbSet<Member> Members { get; set; } 

        public DbSet<UserChatRoom> UserChatRooms { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }
    }
}
