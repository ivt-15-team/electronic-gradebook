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

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //label2.Text = "Долги >" + Convert.ToString(trackBar1.Value);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "Фамилия" || textBox.Text == "Имя" || textBox.Text == "Отчество" || textBox.Text == "Номер зачетной книжки")
                    textBox.Text = string.Empty;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Name == "SecondName" && textBox.Text == string.Empty)
                    textBox.Text = "Фамилия";
                if (textBox.Name == "FirstName" && textBox.Text == string.Empty)
                    textBox.Text = "Имя";
                if (textBox.Name == "ThirdName" && textBox.Text == string.Empty)
                    textBox.Text = "Отчество";
                if (textBox.Name == "Zachetka" && textBox.Text == string.Empty)
                    textBox.Text = "Номер зачетной книжки";
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            EbookContext context = new EbookContext();
            Student st = new Student(SecondName.Text, FirstName.Text, ThirdName.Text, BirthDate.Value, Group.Text, Status.Text);
            context.Students.Add(st);
            context.SaveChanges();
            SecondName.Text = "Фамилия";
            FirstName.Text = "Имя";
            ThirdName.Text = "Отчество";
            Zachetka.Text = "Номер зачетной книжки";
            Group.Text = "Группа";
            Status.Text = "Статус";

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

            string fname, sname, tname,group, status;
            if (FirstName.Text != "Имя")
            {
                fname = FirstName.Text;
                t = t.FindAll(s => s.SecondName == fname);
            }
            if (SecondName.Text != "Фамилия")
            {
                sname = SecondName.Text;
                t = t.FindAll(s => s.FirstName == sname);
            }
            if (ThirdName.Text != "Отчество")
            {
                tname = ThirdName.Text;
                t = t.FindAll(s => s.MiddleName == tname);
            }
            if (Group.Text != "Группа")
            {
                group = Group.Text;
                t = t.FindAll(s => s.GroupName == group);
            }
            if (Status.Text != "Статус")
            {
                status = Status.Text;
                t = t.FindAll(s => s.Status == status);
            }
            //var ss = t.FindAll(s => s.FirstName == "Мент");
            //var ss = from sss in t
            //where sss.FirstName == "Мент"
            //         select sss;



            dataGridView1.DataSource =t;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= context.Students.ToList();
            SecondName.Text = "Фамилия";
            FirstName.Text = "Имя";
            ThirdName.Text = "Отчество";
            Zachetka.Text = "Номер зачетной книжки";
            Group.Text = "Группа";
            Status.Text = "Статус";
        }
    }
}
