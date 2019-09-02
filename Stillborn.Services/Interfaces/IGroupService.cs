using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IGroupService
    {
        void JoinGroup(string userId, int groupId);
        void LeaveGroup(string userId, int groupId);
        IEnumerable<Post> GetPosts(int id);
        void AddPost(string groupId, Post post);
        Content GetContent(int id);
        void SetRole(string userId, int groupId, string roleName);
        int CreateGroup(int? contentId, int WallId);
    }
}
