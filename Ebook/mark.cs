using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Ebook
{
    public class mark
    {
        [Key]
        public int Id { get; set; }

		public string Group_name { get; set; }
		public int Year { get; set; }
		public Student Student { get; set; }
		public EDU_actions Action { get; set; }
		public int Points { get; set; }

		public mark() { }

		public mark(string groupname, int year_enter, EDU_actions Action)
		{

			Group_name = groupname;
			Year = year_enter;
			this.Action = Action;
		}
	}
	public class MarkRepository : IRepository<mark>, IDisposable
	{
		private EbookContext context;

		public MarkRepository(EbookContext context)
		{
			this.context = context;
		}

		public IEnumerable<mark> GetEntities()
		{
			return context.Marks.ToList();
		}

		public mark GetEntityById(int id)
		{
			return context.Marks.Find(id);
		}

		public void InsertEntity(mark mark)
		{
			context.Marks.Add(mark);
		}

		public void DeleteEntity(int markID)
		{
			mark mark = context.Marks.Find(markID);
			context.Marks.Remove(mark);
		}

		public void UpdateEntity(mark mark)
		{
			context.Entry(mark).State = EntityState.Modified;
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
