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
    public partial class Form1 : Form
    {
        SubjectList sub = new SubjectList();
        Studentlist sud = new Studentlist();

        public void check(Form a)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild != a)
            {
                ActiveMdiChild.Hide();
                a.MdiParent = this;
                a.WindowState = FormWindowState.Maximized;
                a.Show();
            }      
            else
            {
                a.MdiParent = this;
                a.WindowState = FormWindowState.Maximized;
                a.Show();
            }
        }

        public bool prov=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            check(sub);          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            check(sud);

        }
    }
}
