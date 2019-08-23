using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class UserChatRoomRepository : IRepository<UserChatRoom>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(UserChatRoom entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
                entity.IsDeleted = false;
                db.UserChatRooms.Add(entity);
                db.SaveChanges();
            }
        }

        public IEnumerable<UserChatRoom> GetAll()
        {
            return db.UserChatRooms;
        }

        public UserChatRoom GetEntity(int id)
        {
            return db.UserChatRooms.FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = db.UserChatRooms.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                db.SaveChanges();
            }
        }

        public void UpdateEntity(UserChatRoom entity)
        {
            var entity1 = db.UserChatRooms.FirstOrDefault(s => s.Id == entity.Id);
            if (entity1 != null)
            {
                entity1.ChatRoomId = entity.ChatRoomId;
                entity1.UserId = entity.UserId;
                db.SaveChanges();
            }
        }
    }
}
