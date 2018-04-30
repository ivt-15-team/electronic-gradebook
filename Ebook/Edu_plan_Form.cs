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
	public partial class Edu_plan_Form : Form
	{
        EDU_plan current_plan;
		public Edu_plan_Form()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            MessageBox.Show("Content Add Attempt");
            // Добавить в план
            current_plan.AddContent(textBox1.Text, textBox2.Text);

            MessageBox.Show("Content Added");

            // Взять из плана (чтоб наверняка)
            Edu_Plan_Content _tmp = current_plan.content.Last();

            MessageBox.Show("Content Get");

            // Стиль
            RowStyle temp = tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1];

            MessageBox.Show("Style Grabbed");

            // increase panel rows count by one
            tableLayoutPanel1.RowCount++;

            MessageBox.Show("Row Increased");

            // add a new RowStyle as a copy of the previous one
            tableLayoutPanel1.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));

            MessageBox.Show("Row Style Add");

            // add your two controls
            tableLayoutPanel1.Controls.Add(new Label() { Text = _tmp.subject_id }, 0, tableLayoutPanel1.RowCount - 1);
            MessageBox.Show("Row Column 1 Add");
            tableLayoutPanel1.Controls.Add(new Label() { Text = Convert.ToString(_tmp.total_hours)}, 1, tableLayoutPanel1.RowCount - 1);
            MessageBox.Show("Row Column 2 Add");
        }

        private void Edu_plan_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current_plan == null)
            {
                current_plan = new EDU_plan(textBox3.Text, textBox4.Text);
                label1.Text = current_plan.Spec_name + " " + Convert.ToString(current_plan.Begin_year);
            }  
        }
    }
}
