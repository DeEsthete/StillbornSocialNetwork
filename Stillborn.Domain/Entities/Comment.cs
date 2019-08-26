using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Comment : Entity
    {
        public int? PostId { get; set; }
        public Post Post { get; set; }

        public int? MediaId { get; set; }
        public Media Media { get; set; }

        public string Text { get; set; }

        public int? ContentId { get; set; }
        public Content Content { get; set; }

        public string SenderId { get; set; }
        public User Sender { get; set; }

        public int Likes { get; set; }
    }
}
