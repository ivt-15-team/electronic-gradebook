using System.Data.Entity;

namespace Ebook
{
    public class EbookContext : DbContext
    {
        public EbookContext() : base("EbookConnection")
        {
        }
    
        public DbSet<User> Users { get; set; }
        public DbSet<ControlType> ControlTypes { get; set; }
        public DbSet<EDU_actions> EduActions { get; set; }
        public DbSet<EDU_plan> EduPlans { get; set; }
        public DbSet<Edu_Plan_Content> EduPlanContents { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<mark> Marks { get; set; }

    }
}
