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
            throw new NotImplementedException();
        }

        public MediaType GenerateMediaType(int typeId)
        {
            return _service.GetRepository<MediaType>().GetEntity(typeId);
        }

        void IContentService.AddMediaInContent(int mediaId, int contentId)
        {
            throw new NotImplementedException();
        }
    }
}
