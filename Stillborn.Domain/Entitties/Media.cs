using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entitties
{
    public class Media : Entity
    {
        public byte[] Bytes { get; set; }

        [ForeignKey("Type")]
        public int TypeId { get; set; }
        public ContentType Type { get; set; }
    }
}
