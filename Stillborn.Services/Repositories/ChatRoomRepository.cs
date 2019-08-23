using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    class ChatRoomRepository : IRepository<ChatRoom>
    {
        private readonly StillbornContext db = new StillbornContext();
        public void AddEntity(ChatRoom entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.ChatRooms.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<ChatRoom> GetAll()
        {
            return db.ChatRooms;
        }

        public ChatRoom GetEntity(int id)
        {
            return db.ChatRooms.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.ChatRooms.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(ChatRoom entity)
        {
            var entity1 = db.ChatRooms.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.CreatorId = entity.CreatorId;
                entity1.Messages = entity.Messages;
                entity1.Users = entity.Users;
                db.SaveChanges();
            }
        }
    }
}
