using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class MediaRepository:IRepository<Media>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(Media entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.Medias.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<Media> GetAll()
        {
            return db.Medias;
        }

        public Media GetEntity(int id)
        {
            return db.Medias.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.Medias.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(Media entity)
        {
            var entity1 = db.Medias.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.Contents = entity.Contents;
                db.SaveChanges();
            }
        }
    }
}
