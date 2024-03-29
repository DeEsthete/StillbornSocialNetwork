﻿using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using Stillborn.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Services
{
    public class ContentService : IContentService
    {
        private readonly RepositoryService _service;
        public ContentService(RepositoryService service)
        {
            _service = service;
        }

        public Content GenerateContent()
        {
            Content content = new Content();
            _service.GetRepository<Content>().Add(content);
            return content;
        }

        public Media GenerateMedia(byte[] Bytes, int typeId)
        {
            Media media = new Media();
            media.Bytes = Bytes;
            media.Likes = 0;
            media.TypeId = typeId;
            _service.GetRepository<Media>().Add(media);
            return media;
        }

        void IContentService.AddMediaInContent(int mediaId, int contentId)
        {
            Media media = _service.GetRepository<Media>().FindById(mediaId);
            media.ContentId = _service.GetRepository<Content>().FindById(contentId).Id;
            _service.GetRepository<Media>().Update(media);
        }
    }
}
