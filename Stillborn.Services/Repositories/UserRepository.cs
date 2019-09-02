using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class UserRepository
    {
        private readonly StillbornContext _context = new StillbornContext();

        public void AddEntity(User user)
        {
            if (user != null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }
        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
        public User GetEntity(string id)
        {
            return _context.Users.FirstOrDefault(p => p.Id == id);
        }
        public void RemoveEntity(string id)
        {
            User user = _context.Users.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                user.IsDeleted = true;
                user.DeletedDate = DateTime.UtcNow;
                _context.SaveChanges();
            }
        }
        public void UpdateEntity(User user)
        {
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
