using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ebook.Repositories
{
    class StudentRepository : IRepository<Student>
    {
        private EbookContext context;

        public StudentRepository(EbookContext context)
        {
            this.context = context;
        }

        public void DeleteEntity(int entityID)
        {
            Student student = context.Students.Find(entityID);
            context.Students.Remove(student);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<Student> GetEntities()
        {
            return context.Students.ToList();
        }

        public Student GetEntityById(int entityID)
        {
            return context.Students.Find(entityID);
        }

        public void InsertEntity(Student entity)
        {
            context.Students.Add(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateEntity(Student entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
