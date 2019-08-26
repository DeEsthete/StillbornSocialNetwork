using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class MediaRepository:IRepository<Content>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(Content entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.Content.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<Content> GetAll()
        {
            return db.Content;
        }

        public Content GetEntity(int id)
        {
            return db.Content.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.Content.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(Content entity)
        {
            var entity1 = db.Content.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.Media = entity.Media;
                db.SaveChanges();
            }
        }
    }
}
