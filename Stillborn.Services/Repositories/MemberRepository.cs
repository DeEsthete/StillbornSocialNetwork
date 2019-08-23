using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class MemberRepository : IRepository<Member>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(Member entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.Members.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<Member> GetAll()
        {
            return db.Members;
        }

        public Member GetEntity(int id)
        {
            return db.Members.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.Members.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(Member entity)
        {
            var entity1 = db.Members.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.GroupId = entity.GroupId;
                entity1.RoleId = entity.RoleId;
                entity1.UserId = entity.UserId;
                db.SaveChanges();
            }
        }
    }
}
