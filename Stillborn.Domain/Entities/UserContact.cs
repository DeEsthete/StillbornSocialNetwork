using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Domain.Entities
{
    public class UserContact : Entity
    {
        public int MainUserId { get; set; }
        public User MainUser { get; set; }

        public int SecondUserId { get; set; }
        public User SecondUser { get; set; }

        //Тип контакта например: block, friend, follower
        public int TypeId { get; set; }
        public ContactType Type { get; set; }
    }
}
