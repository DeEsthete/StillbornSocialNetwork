using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class ContentRepository:IRepository<Media>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(Media entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Media> GetAll()
        {
            throw new NotImplementedException();
        }

        public Media GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Media entity)
        {
            throw new NotImplementedException();
        }
    }
}
