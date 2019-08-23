using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class RepositoryService
    {
        private readonly StillbornContext _context;
        public RepositoryService(StillbornContext context)
        {
            _context = context;
        }
        public  IRepository<T> GetRepository<T>() where T : Entity
        {
            return new Repository<T>(_context);
        }
    }
}
