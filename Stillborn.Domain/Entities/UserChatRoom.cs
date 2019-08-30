using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class UserChatRoom : Entity
    {
        public string UserId { get; set; }//creator?
        public User User { get; set; }

        public int ChatRoomId { get; set; }
        public ChatRoom ChatRoom { get; set; }
    }
}
