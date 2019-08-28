using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IGroupService
    {
        bool JoinGroup(string userId, int groupId);
        bool LeaveGroup(string userId, int groupId);
        IEnumerable<Post> GetPosts(int id);
        bool AddPost(string groupId, Post post);
        Content GetContent(int id);
        bool SetRole(string userId, int groupId, string roleName);
    }
}
