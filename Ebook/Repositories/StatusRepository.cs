using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ebook.Repositories
{
    class StatusRepository : IRepository<Status>
    {
        private EbookContext context;

        public StatusRepository(EbookContext context)
        {
            this.context = context;
        }

        public void DeleteEntity(int entityID)
        {
            Status status = context.Statuses.Find(entityID);
            context.Statuses.Remove(status);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<Status> GetEntities()
        {
            return context.Statuses.ToList();
        }

        public Status GetEntityById(int entityID)
        {
            return context.Statuses.Find(entityID);
        }

        public void InsertEntity(Status entity)
        {
            context.Statuses.Add(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateEntity(Status entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
