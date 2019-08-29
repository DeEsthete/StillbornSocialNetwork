using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IContentService
    {
        MediaType GenerateMediaType(string type);
        Media GenerateMedia(byte[] Bytes,int typeId);
        Content GenerateContent(IEnumerable<Media> content);
    }
}
