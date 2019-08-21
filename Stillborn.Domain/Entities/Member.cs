using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Member : Entity
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }
        public Group Group { get; set; }

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }
        public GroupRole Role { get; set; }
    }
}
