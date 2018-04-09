using System;
using System.Collections.Generic;

namespace Ebook
{
    interface IRepository<T> : IDisposable
    {
        IEnumerable<T> GetEntities();
        T GetEntityById(int entityID);
        void InsertEntity(T entity);
        void DeleteEntity(int entityID);
        void UpdateEntity(T entity);
        void Save();
    }
}
