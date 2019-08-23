using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class MessageRepository:IRepository<Message>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(Message entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.Messages.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<Message> GetAll()
        {
            return db.Messages;
        }

        public Message GetEntity(int id)
        {
            return db.Messages.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.Messages.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(Message entity)
        {
            var entity1 = db.Messages.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.ChatRoomId = entity.ChatRoomId;
                entity1.MediaId = entity.MediaId;
                entity1.SenderId = entity.SenderId;
                entity1.Text = entity.Text;
                db.SaveChanges();
            }
        }
    }
}
