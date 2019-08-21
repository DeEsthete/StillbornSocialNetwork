using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }

        public DbSet<User> Users { get; set; }
    }
}
