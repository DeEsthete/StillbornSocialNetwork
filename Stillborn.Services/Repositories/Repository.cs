using Stillborn.Domain.Data;
using Stillborn.Domain.Entities;
using Stillborn.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stillborn.Services.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly StillbornContext _context;

        public Repository(StillbornContext context)
        {
            _context = context;
        }
        public void AddEntity(T entity)
        {
            if (entity != null)
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetEntity(int id)
        {
            return _context.Set<T>().FirstOrDefault(i => i.Id == id);
        }

        public void RemoveEntity(int id)
        {
            var entity = _context.Set<T>().FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.UtcNow;
                _context.SaveChanges();
            }
        }

        public void UpdateEntity(T entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
