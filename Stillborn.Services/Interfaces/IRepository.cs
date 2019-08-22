using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IRepository<T>
    {
        void AddEntity(T entity);

        void RemoverEntity(int id);

        void UpdateEntity(T entity);

        IEnumerable<T> GetAll();

        T GetEntity(int id);
    }
}
