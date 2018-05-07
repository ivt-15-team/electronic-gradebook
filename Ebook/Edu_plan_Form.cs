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
        // To Program.cs
        //static public List<EDU_plan> EDU_plans = new List<EDU_plan>();
        EDU_plan current_plan;
        public Edu_plan_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавить в план
            current_plan.AddContent(textBox1.Text, textBox2.Text);

            // Взять из плана (чтоб наверняка)
            Edu_Plan_Content _tmp = current_plan.content.Last();

            reload_EDU_plan_content();      
        }

        private void Edu_plan_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             //current_plan = new EDU_plan(textBox3.Text, textBox4.Text);
        }

        //private void reload_EDU_plan()
        //{
        //    foreach(var _tmp in Ebook.Program.EDU_plans)
        //    {
        //        DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
        //        row.Cells[0].Value = _tmp.Spec_name;
        //        row.Cells[1].Value = Convert.ToString(_tmp.Begin_year);
        //        dataGridView1.Rows.Add(row);
        //    }
        //}

        private void reload_EDU_plan_content()
        {
            foreach (var _tmp in current_plan.content)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = _tmp.subject_id;
                row.Cells[1].Value = Convert.ToString(_tmp.total_hours);
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
