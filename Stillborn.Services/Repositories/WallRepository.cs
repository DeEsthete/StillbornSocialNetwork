using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class WallRepository:IRepository<Wall>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(Wall entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.Walls.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<Wall> GetAll()
        {
            return db.Walls;
        }

        public Wall GetEntity(int id)
        {
            return db.Walls.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.Walls.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(Wall entity)
        {
            var entity1 = db.Walls.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.Posts = entity.Posts;
                db.SaveChanges();
            }
        }
    }
}
