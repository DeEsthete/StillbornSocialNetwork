using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Content : Entity
    {
        public IEnumerable<Media> Media { get; set; }
    }
}
