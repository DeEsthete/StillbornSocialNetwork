using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entitties
{
    public class Article : Entity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public MyUser User { get; set; }
        public int Likes { get; set; }
        public IEnumerable<ContentMessage> Comments { get; set; }
        [ForeignKey("Type")]
        public int TypeId { get; set; }
        public ContentType Type { get; set; }
    }
}
