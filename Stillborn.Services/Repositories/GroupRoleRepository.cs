using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class GroupRoleRepository : IRepository<GroupRole>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(GroupRole entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.GroupRoles.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<GroupRole> GetAll()
        {
            return db.GroupRoles;
        }

        public GroupRole GetEntity(int id)
        {
            return db.GroupRoles.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.GroupRoles.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(GroupRole entity)
        {
            var entity1 = db.GroupRoles.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.Name = entity.Name;
                db.SaveChanges();
            }
        }
    }
}
