using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class ContentTypeRepository : IRepository<MediaType>
    {
        private readonly StillbornContext db = new StillbornContext();
        public void AddEntity(MediaType entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.MediaTypes.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<MediaType> GetAll()
        {
            return db.MediaTypes;
        }

        public MediaType GetEntity(int id)
        {
            return db.MediaTypes.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.MediaTypes.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(MediaType entity)
        {
            var entity1 = db.MediaTypes.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.Name= entity.Name;
                db.SaveChanges();
            }
        }
    }
}
