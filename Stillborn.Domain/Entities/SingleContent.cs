using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class SingleContent : Entity
    {
        [ForeignKey(nameof(Content))]
        public int ContentId { get; set; }
        public Content Content { get; set; }

        public int Likes { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
