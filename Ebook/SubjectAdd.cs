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
	public partial class SubjectAdd : Form
	{
		EbookContext context;
		SubjectRepository repo;
		bool proverka = false;
        bool edit = false;
        bool chsnitemedit = false;
        List<Subject> s;

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
            s = (List<Subject>)repo.GetSubject();
            comboBox1.Items.Clear();
            foreach (Subject subj in s)
            {
                comboBox1.Items.Add(subj.Name);
                //comboBox1.Items[comboBox1.Items.Count - 1];
            }
            comboBox1.Enabled = false;
            button3.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (edit == false)
            {
                edit = true;
                comboBox1.Enabled = true;
                button3.Enabled = true;
                textBox2.Enabled = true;
                button1.Enabled = false;
                textBox1.Enabled = false;
                label1.Text = "Режим работы: Изменение";
            }
            else if (edit == true)
            {
                edit = false;
                comboBox1.Enabled = false;
                button3.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = true;
                textBox1.Enabled = true;
                label1.Text = "Режим работы: Добавление";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((chsnitemedit == false)&&(comboBox1.SelectedIndex != -1))
            {
                comboBox1.Enabled = false;
                comboBox1.Visible = false;
                label2.Text = "Введите новое название предмета";
                textBox2.Visible = true;
                textBox2.Enabled = true;
                chsnitemedit = true;
                foreach(Subject subj in s)
                {
                    if (subj.Name.CompareTo(comboBox1.Text) == 0)
                    {

                    }
                }
            }
            else if (chsnitemedit == true)
            {
                comboBox1.Enabled = true;
                comboBox1.Visible = true;
                label2.Text = "Выберите предмет";
                textBox2.Visible = false;
                textBox2.Enabled = false;
                chsnitemedit = false;
            }
        }
    }
}
