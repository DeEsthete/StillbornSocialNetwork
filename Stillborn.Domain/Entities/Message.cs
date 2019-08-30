using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class Message : Entity
    {
        //Имеется
        public int ChatRoomId { get; set; }
        public ChatRoom ChatRoom { get; set; }

        //Имеет
        public string SenderId { get; set; }
        public User Sender { get; set; }

        public string Text { get; set; }//не нужное поле / text лучше сделать Media / в Message находится Content с разными типами Media

        public int? ContentId { get; set; }
        public Content Content { get; set; }
    }
}
