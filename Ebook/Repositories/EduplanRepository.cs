using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ebook.Repositories
{
    class EduplanRepository : IRepository<EDU_plan>
    {
        private EbookContext context;

        public EduplanRepository(EbookContext context)
        {
            this.context = context;
        }

        public void DeleteEntity(int entityID)
        {
            var eduplan = context.EduPlans.Find(entityID);
            context.EduPlans.Remove(eduplan);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<EDU_plan> GetEntities()
        {
            return context.EduPlans.ToList();
        }

        public EDU_plan GetEntityById(int entityID)
        {
            return context.EduPlans.Find(entityID);
        }

        public void InsertEntity(EDU_plan entity)
        {
            context.EduPlans.Add(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateEntity(EDU_plan entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
