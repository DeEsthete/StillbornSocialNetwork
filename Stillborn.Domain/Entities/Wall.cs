using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Wall : Entity
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
