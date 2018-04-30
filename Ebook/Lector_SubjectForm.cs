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
    public partial class Lector_SubjectForm : Form
    {
        public Lector_SubjectForm(Lessons data)
        {
            InitializeComponent();
            label1.Text = data.name;
        }
    }
}
