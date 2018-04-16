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
    public partial class Autorization : Form
    {
        private int access = 0;
        private string pass;

        EbookContext context;
        
        public Autorization()
        {
            InitializeComponent();
            context = new EbookContext();
        }

        private string hash(string a)
        {
            return a;
        }

        private void button1_Click (object sender, EventArgs e) 
        {
            label1.Visible = false;
            if ((textBox1.Text != null) && (textBox2.Text != null))
            {
                try
                {
                    var user = context.Users.ToList().Find(u => u.Login == textBox1.Text);
                    if (user != null)
                    {
                        string hPass = hash(textBox2.Text);
                        if (user.Password == hPass)
                        {
                            Program.login = user.Login;
                            Form1 frm = new Form1();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            label1.Text = "Неверный логин/пароль!";
                            label1.Visible = true;
                        }
                    }
                    else
                    {
                        label1.Text = "Такого пользователя не существует!";
                        label1.Visible = true;
                    }
                }
                catch
                {
                    label1.Text = "Ошибка подключения к БД!" + e;
                    label1.Visible = true;
                }                  
            }
            else
            {                
                label1.Text = "Не все поля заполнены!";
                label1.Visible = true;
            }
        }
    }
}
