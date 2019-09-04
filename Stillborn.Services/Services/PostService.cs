using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Services
{
    public class PostService : IPostService
    {
        private readonly RepositoryService _service;
        public PostService(RepositoryService service)
        {
            _service = service;
        }
        public Post GeneratePost(int wallId, int? contentId, string text)
        {
            Post post = new Post();
            post.WallId = wallId;
            post.ContentId = contentId;
            post.Text = text;
            _service.GetRepository<Post>().Add(post);
            return post;
        }
    }
}
