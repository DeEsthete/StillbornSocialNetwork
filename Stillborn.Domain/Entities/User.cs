using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class User : IdentityUser
    {
        public string NickName { get; set; }
        public bool IsMan { get; set; }

        public int WallId { get; set; }
        public Wall Wall { get; set; }

        public int ContentId { get; set; }
        public Content Content { get; set; }

        public IEnumerable<UserChatRoom> ChatRooms { get; set; }
        public IEnumerable<Member> Groups { get; set; }

        public bool IsDeleted { get; set; } = false;
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedDate { get; set; }
    }
}
