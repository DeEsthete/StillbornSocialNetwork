using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class UserContactRepository : IRepository<UserContact>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(UserContact entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.UserContacts.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<UserContact> GetAll()
        {
            return db.UserContacts;
        }

        public UserContact GetEntity(int id)
        {
            return db.UserContacts.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.UserContacts.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(UserContact entity)
        {
            var entity1 = db.UserContacts.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.MainUserId = entity.MainUserId;
                entity1.SecondUserId = entity.SecondUserId;
                entity1.TypeId = entity.TypeId;
                db.SaveChanges();
            }
        }
    }
}
