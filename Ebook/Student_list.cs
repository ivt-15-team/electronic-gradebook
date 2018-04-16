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
        public Studentlist()
        {
            InitializeComponent();
        }
        private int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "sd";
            if (k == 0)
            {
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

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //label2.Text = "Долги >" + Convert.ToString(trackBar1.Value);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)

                if ((sender as TextBox).Text == "Фамилия")
                    (sender as TextBox).Text = "";
            if ((sender as TextBox).Text == "Имя")
                (sender as TextBox).Text = "";


        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
                if((sender as TextBox).Name == "textBox1")
                {
                    if ((sender as TextBox).Text == "")
                    {                        
                        textBox1.Text = "Фамилия";
                    }
                    
                }
            if ((sender as TextBox).Name == "textBox2")
            {
                if ((sender as TextBox).Text == "")
                {
                    (sender as TextBox).Text = "Имя";
                }

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
    }
}
