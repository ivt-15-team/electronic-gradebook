﻿using System;
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

	//static public List<EDU_plan> EDU_plans = new List<EDU_plan>();

    public partial class Edu_plan_Form : Form
    {
        EDU_plan current_plan;
        public Edu_plan_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current_plan == null)
            {
                MessageBox.Show("Нет плана");
                return;
            }
            // Добавить в план
            current_plan.AddContent(textBox1.Text, textBox2.Text, textBox5.Text, textBox6.Text);

            reload_EDU_plan_content();
        }

        private void Edu_plan_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EDU_plan tmp_EDU_plan = new EDU_plan(textBox3.Text, textBox4.Text);

            // Заменить на запрос добавления в БД
            //Program.EDU_plans.Add(tmp_EDU_plan);

            // Взять из списка планов (чтоб наверняка)
            //current_plan = Program.EDU_plans.Last();

            reload_EDU_plan();
        }

        private void reload_EDU_plan()
        {
            dataGridView2.Rows.Clear();
            //foreach (var _tmp in Program.EDU_plans)
            //{
            //    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            //    row.Cells[0].Value = _tmp.UId;
            //    row.Cells[1].Value = _tmp.Spec_name;
            //    row.Cells[2].Value = Convert.ToString(_tmp.Begin_year);
            //    dataGridView2.Rows.Add(row);
            //}
        }

        private void reload_EDU_plan_content()
        {
            if (current_plan == null)
            {
                MessageBox.Show("Нет плана");
                return;
            }
            dataGridView1.Rows.Clear();

            // Заменить на запрос
            //foreach (var _tmp in Program.EDU_plan_Contents)
            //{
            //    if (current_plan.UId != _tmp.EduPlanUID)
            //        continue;
            //    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            //    row.Cells[0].Value = Convert.ToString(_tmp.UId);
            //    row.Cells[1].Value = _tmp.subject_id;
            //    row.Cells[2].Value = Convert.ToString(_tmp.total_hours);
            //    row.Cells[3].Value = _tmp.ControlType;
            //    row.Cells[4].Value = _tmp.employee;
            //    dataGridView1.Rows.Add(row);
            //}
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView2.CurrentRow;
            int _id = Convert.ToInt32(row.Cells[0].Value);

            //current_plan = Program.EDU_plans.Find(x => x.UId == _id);

            reload_EDU_plan_content();
        }
    }
}
