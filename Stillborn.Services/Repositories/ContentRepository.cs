using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class ContentRepository:IRepository<Content>
    {
        private readonly StillbornContext db = new StillbornContext();

        public void AddEntity(Content entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Content> GetAll()
        {
            throw new NotImplementedException();
        }

        public Content GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Content entity)
        {
            throw new NotImplementedException();
        }
    }
}
