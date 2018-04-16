using System;
namespace Ebook
{
	class SubjectRepository:IRepository<Subject>,IDisposable
	{
        EbookContext context;
        public SubjectRepository(EbookContext context)
        {
            this.context = context;
        }
        public IEnumerable<Subject> GetEntities()
        {
            return context.Subject.ToList();
        }
        public Subject GetEntityById(int entityID)
        {
            return context.Subject.Find(entityID);
        }
        public void InsertEntity(Subject entity)
        {
            context.Subject.Add(entity);

        }
        public void DeleteEntity(int entityID)
        {
            Subject subject = context.Subject.Find(entityID);
            context.Subject.Remove(subject);
        }
        public void UpdateEntity(Subject entity)
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
