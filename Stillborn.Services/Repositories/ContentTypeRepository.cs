using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class ContentTypeRepository : IRepository<ContentType>
    {
        private readonly StillbornContext db = new StillbornContext();
        public void AddEntity(ContentType entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.ContentTypes.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<ContentType> GetAll()
        {
            return db.ContentTypes;
        }

        public ContentType GetEntity(int id)
        {
            return db.ContentTypes.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.ContentTypes.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(ContentType entity)
        {
            var entity1 = db.ContentTypes.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.Name= entity.Name;
                db.SaveChanges();
            }
        }
    }
}
