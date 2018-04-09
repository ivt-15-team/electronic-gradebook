using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook
{
    class Group_repository:IRepository<Group>, IDisposable
    {
        EbookContext context;
        public Group_repository(EbookContext context)
        {
            this.context = context;
        }
        public IEnumerable<Group> GetEntities()
        {
            return context.Groups.ToList();
        }
        public Group GetEntityById(int entityID)
        {
            return context.Groups.Find(entityID);
        }
        public  void InsertEntity(Group entity)
        {
            context.Groups.Add(entity);
            
        }
        public void DeleteEntity(int entityID)
        {
            Group group = context.Groups.Find(entityID);
            context.Groups.Remove(group);
        }
        public void UpdateEntity(Group entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
