using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Domain.Entities
{
    //index соответствует id
    public enum ContactTypes
    {
        Friend = 1,
        Follower,
        Blocked
    }

    public enum MediaTypes
    {
        Image =1,
        Music,
        Video
    }

    public enum GroupRoles
    {
        Admin=1,
        Subscriber
    }
    public enum BaseRoles
    {
        Admin,
        User
    }


}
