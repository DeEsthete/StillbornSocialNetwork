using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private readonly StillbornContext db = new StillbornContext();
        public void AddEntity(Post entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.Posts.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }

        public Post GetEntity(int id)
        {
            return db.Posts.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.Posts.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(Post entity)
        {
            var entity1 = db.Posts.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.Comments = entity.Comments; 
                entity1.Likes = entity.Likes;
                entity1.ContentId = entity.ContentId;
                entity1.Text = entity.Text;
                entity1.WallId = entity.WallId;
                db.SaveChanges();
            }

        }
    }
}
