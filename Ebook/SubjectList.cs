using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Ebook
{
    
    public partial class SubjectList : Form
    {
        public SubjectList()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

    public class SubjectRepository : ISubjectRepository, IDisposable
    {
        private EbookContext context;

        public SubjectRepository(EbookContext context)
        {
            this.context = context;
        }

        public IEnumerable<Subject> GetSubject()
        {
            return context.Subjects.ToList();
        }

        public Subject GetSubjectByID(int id)
        {
            return context.Subjects.Find(id);
        }

        public void InsertSubject(Subject subject)
        {
            context.Subjects.Add(subject);
        }

        public void DeleteSubject(int subjectID)
        {
            Subject subject = context.Subjects.Find(subjectID);
            context.Subjects.Remove(subject);
        }

        public void UpdateSubject(Subject subject)
        {
            context.Entry(subject).State = EntityState.Modified;
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
