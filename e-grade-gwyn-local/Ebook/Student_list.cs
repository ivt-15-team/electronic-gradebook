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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "Долги >" + Convert.ToString(trackBar1.Value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
