using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(Group entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.Groups.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<Group> GetAll()
        {
            return db.Groups;
        }

        public Group GetEntity(int id)
        {
            return db.Groups.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.Groups.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(Group entity)
        {
            var entity1 = db.Groups.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.Contents = entity.Contents;
                entity1.Members = entity.Members;
                entity1.WallId = entity.WallId;
                db.SaveChanges();
            }
        }
    }
}
