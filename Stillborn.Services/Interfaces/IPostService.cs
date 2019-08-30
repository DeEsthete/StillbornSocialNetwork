using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IPostService
    {
        Post GeneratePost(int wallId,int? contentId,string text,int likes);
        
    }
}
