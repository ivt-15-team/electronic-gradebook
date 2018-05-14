using System;
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
    public partial class SubjectEdit : Form
    {
        public SubjectEdit(Subject subj)
        {
            InitializeComponent();
            subject = subj;
        }

        private Subject subject;

        private void SubjectEdit_Load(object sender, EventArgs e)
        {
            label2.Text = subject.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subject.Name = textBox1.Text;
            this.Close();
        }
    }
}
