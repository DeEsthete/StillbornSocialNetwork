using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Media : Entity
    {
        //Имеется в
        public int? ContentId { get; set; }
        public Content Content { get; set; }

        //Имеет
        public byte[] Bytes { get; set; }

        public int TypeId { get; set; }
        public MediaType Type { get; set; }

        public int Likes { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
