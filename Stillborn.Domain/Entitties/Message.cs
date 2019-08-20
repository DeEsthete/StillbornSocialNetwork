using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Domain.Entitties
{
    public class Message : Entity
    {
        public MyUser Sender { get; set; }
        public IEnumerable<Media> Medias { get; set; }
    }
}
