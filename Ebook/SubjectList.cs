﻿using System;
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
        EbookContext context;
        SubjectRepository repo;
        List<Subject> s;
        public SubjectList()
        {
            InitializeComponent();
            context = new EbookContext();
            repo = new SubjectRepository(context);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var subj = dataGridView1.Rows[e.RowIndex].DataBoundItem as Subject;
            SubjectEdit frm2 = new SubjectEdit(subj, repo);
            //DataGridViewSelectedCellCollection;
            //frm2.MdiParent = this.MdiParent;
            //frm2.WindowState = FormWindowState.Maximized;
            //frm2.Show();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repo.GetSubject();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            repo.Save();
            this.Close();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			SubjectAdd frm = new SubjectAdd();
			frm.MdiParent = this.MdiParent;
			frm.WindowState = FormWindowState.Maximized;
			frm.Show();
		}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close(object sender, FormClosedEventArgs e)
        {
            repo.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repo.GetSubject();
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
