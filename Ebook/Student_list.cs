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
    public partial class Studentlist : Form
    {
        EbookContext context = new EbookContext();

        public Studentlist()
        {
            InitializeComponent();
        }
        private int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "sd";
            k = (k + 1) % 3;
            if (k == 0)
                button1.Text = ">";
            if (k == 1)
                button1.Text = "<";
            if (k == 2)
                button1.Text = "=";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //label2.Text = "Долги >" + Convert.ToString(trackBar1.Value);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "Фамилия" || textBox.Text == "Имя")
                    textBox.Text = string.Empty;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Name == "textBox1" && textBox.Text == string.Empty)
                    textBox.Text = "Фамилия";
                if (textBox.Name == "textBox2" && textBox.Text == string.Empty)
                    textBox.Text = "Имя";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = "sd";
            if (k == 0) {
                button1.Text = ">";
                k++;
            }
            if (k == 1)
            {
                button1.Text = "<";
                k++;
            }
            if (k == 2)
            {
                button1.Text = "=";
                k = 0;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EbookContext context = new EbookContext();
            Student st = new Student(SecondName.Text, FirstName.Text, ThirdName.Text, new DateTime(2001, 1, 1), Group.Text, Status.Text);
            context.Students.Add(st);
            context.SaveChanges();
            
        }

        private void Studentlist_Load(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = context.Students.ToList();
            
            //List<Student> s = (List<Student>)context.Students.;
            //comboBox1.Items.Clear();
            //foreach (Subject subj in s)
            //{
            //    comboBox1.Items.Add(subj.Name);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Student> t = context.Students.ToList();
            //filter

            string fname, sname, tname,group;
            if (FirstName.Text != "Имя")
            {
                fname = FirstName.Text;
            }
            if (SecondName.Text != "Фамилия")
            {
                sname = SecondName.Text;
            }
            if (ThirdName.Text != "Отчество")
            {
                tname = ThirdName.Text;
            }
            if (Group.Text != "Группа")
            {
                group = Group.Text;
            }
            
            

            

            dataGridView1.DataSource = t;
        }
    }
}
