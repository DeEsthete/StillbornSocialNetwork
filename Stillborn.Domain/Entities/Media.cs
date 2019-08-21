using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Media : Entity
    {
        public IEnumerable<Content> Contents { get; set; }
    }
}
