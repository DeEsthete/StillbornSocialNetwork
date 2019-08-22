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
        public int SenderId { get; set; }
        public User Sender { get; set; }

        public string Text { get; set; }

        public int? MediaId { get; set; }
        public Media Media { get; set; }
    }
}
