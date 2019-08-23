using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private readonly StillbornContext db = new StillbornContext();
        public void AddEntity(Comment entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.Comments.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<Comment> GetAll()
        {
            return db.Comments;
        }

        public Comment GetEntity(int id)
        {
            return db.Comments.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.Comments.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(Comment entity)
        {
            var entity1 = db.Comments.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.ContentId = entity.ContentId;
                entity1.Likes = entity.Likes;
                entity1.MediaId = entity.MediaId;
                entity1.Text = entity.Text;
                entity1.PostId = entity.PostId;
                db.SaveChanges();
            }
        }
    }
}
