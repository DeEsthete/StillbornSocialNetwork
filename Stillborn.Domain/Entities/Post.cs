﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Post : Entity
    {
        //Имеется в
        public int WallId { get; set; }
        public Wall Wall { get; set; }

        //Содержит
        public int? ContentId { get; set; }
        public Content Content { get; set; }

        public string Text { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
