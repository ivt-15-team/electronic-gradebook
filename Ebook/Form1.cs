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
        LectorList sul = new LectorList();

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
            /*Разграничение прав доступа
             
            if (Program.access == 1)
            {
                button.Enabled = false;
            }
            else if (Program.access == 2)
            {
                button.Enabled = false;
            }
            else if (Program.access == 3)
            {
                button.Enabled = false;
            }
            */
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

        private void button3_Click(object sender, EventArgs e)
        {
            check(sul);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RequsetParser RP = new RequsetParser();
            textBox1.Text = (RP.request("ИМИ"));
        }
    }
}
