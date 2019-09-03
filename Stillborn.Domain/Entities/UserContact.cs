using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Domain.Entities
{
    /// <summary>
    /// for link mainuser to other
    /// </summary>
    public class UserContact : Entity
    {
        public string MainUserId { get; set; }
        public User MainUser { get; set; }

        public string SecondUserId { get; set; }
        public User SecondUser { get; set; }

        //Тип контакта например: block, friend, follower
        public int TypeId { get; set; }
        public ContactType Type { get; set; }
    }
}
