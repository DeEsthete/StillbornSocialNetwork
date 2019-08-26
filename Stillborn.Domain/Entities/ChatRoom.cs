using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class ChatRoom : Entity
    {
        public string CreatorId { get; set; }
        public User Creator { get; set; }

        public IEnumerable<UserChatRoom> Users { get; set; }

        public IEnumerable<Message> Messages { get; set; }
    }
}
