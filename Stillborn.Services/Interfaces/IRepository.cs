using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);

        void Remove(int id);

        void Update(T entity);

        IEnumerable<T> GetAll();

        T FindById(int id);
    }
}
