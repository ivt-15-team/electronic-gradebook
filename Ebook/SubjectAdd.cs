﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebook
{
	public partial class SubjectAdd : Form
	{
		EbookContext context;
		SubjectRepository repo;
		bool proverka = false;
		public SubjectAdd()
		{
			context = new EbookContext();
			repo = new SubjectRepository(context);
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Subject s = new Subject(textBox1.Text);
			repo.InsertSubject(s);
			repo.Save();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TextChanged(object sender, EventArgs e)
		{
			if (!proverka)
			{
				textBox1.Text = "";
				proverka = true;
			}
		}

        private void SubjectAdd_Load(object sender, EventArgs e)
        {
            int n, i;
            List<Subject> s = (List<Subject>)repo.GetSubject();
            comboBox1.Items.Clear();
            foreach (Subject subj in s)
            {
                comboBox1.Items.Add(subj.Name);
            }
            
        }
    }
}