using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Services
{
    public class ContentSevice : IContentService
    {
        private readonly RepositoryService _service;
        public ContentSevice(RepositoryService service)
        {
            _service = service;
        }

        public Content GenerateContent()
        {
            Content content = new Content();
            _service.GetRepository<Content>().AddEntity(content);
            return content;
        }

        public Media GenerateMedia(byte[] Bytes, int typeId)
        {
            Media media = new Media();
            media.Bytes = Bytes;
            media.Likes = 0;
            media.TypeId = typeId;
            _service.GetRepository<Media>().AddEntity(media);
            return media;
        }

        public MediaType GenerateMediaType(int typeId)
        {
            return _service.GetRepository<MediaType>().GetEntity(typeId);
        }

        void IContentService.AddMediaInContent(int mediaId, int contentId)
        {
            Media media = _service.GetRepository<Media>().GetEntity(mediaId);
            media.ContentId = _service.GetRepository<Content>().GetEntity(contentId).Id;
            _service.GetRepository<Media>().UpdateEntity(media);
        }
    }
}
