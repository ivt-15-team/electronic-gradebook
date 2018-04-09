using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ebook.Repositories
{
    class UserRepository : IRepository<User>
    {
        private EbookContext context;

        public UserRepository(EbookContext context)
        {
            this.context = context;
        }

        public void DeleteEntity(int entityID)
        {
            var user = context.Users.Find(entityID);
            context.Users.Remove(user);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<User> GetEntities()
        {
            return context.Users.ToList();
        }

        public User GetEntityById(int entityID)
        {
            return context.Users.Find(entityID);
        }

        public void InsertEntity(User entity)
        {
            context.Users.Add(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateEntity(User entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
