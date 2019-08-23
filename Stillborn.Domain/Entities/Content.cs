using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Content : Entity
    {
        //Имеется в
        public int? MediaId { get; set; }
        public Media Media { get; set; }

        //Имеет
        public byte[] Bytes { get; set; }

        public int TypeId { get; set; }
        public ContentType Type { get; set; }

        public int Likes { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
