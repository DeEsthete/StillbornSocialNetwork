using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class ContactTypeRepository : IRepository<ContactType>
    {
        private readonly StillbornContext db = new StillbornContext();
        public void AddEntity(ContactType entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.ContactTypes.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<ContactType> GetAll()
        {
            return db.ContactTypes;
        }

        public ContactType GetEntity(int id)
        {
            return db.ContactTypes.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.ContactTypes.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(ContactType entity)
        {
            var entity1 = db.ContactTypes.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.Name = entity.Name;
                db.SaveChanges();
            }
        }
    }
}
