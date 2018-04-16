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

        private void UpdateWarningText(string message)
        {
            label1.Text = message;
            label1.Visible = !string.IsNullOrEmpty(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateWarningText(string.Empty);
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                UpdateWarningText("Не все поля заполнены");
            }
            else
            {
                try
                {
                    User user = context.Users.Where(u => u.Login == login).FirstOrDefault();
                    if (user == null)
                    {
                        UpdateWarningText("Неверный логин/пароль");
                    }
                    else
                    {
                        string passwordHashed = hash(password);
                        if (user.Password == passwordHashed)
                        {
                            Program.login = user.Login;
                            Form1 frm = new Form1();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            UpdateWarningText("Неверный логин/пароль");
                        }
                    }
                }
                catch (Exception exc)
                {
                    UpdateWarningText($"Ошибка подключения к БД! {exc.ToString()}");
                }
            }
        }
    }
}
