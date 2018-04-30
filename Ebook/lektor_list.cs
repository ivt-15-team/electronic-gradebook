using System;
using System.Windows.Forms;
using System.Linq;

namespace Ebook
{
    public partial class LectorList : Form
    {
        EbookContext context;

        public LectorList()
        {
            InitializeComponent();
            context = new EbookContext();
            dataGridView1.DataSource = context.Lessons.ToList();
            comboBox1.DataSource = context.Lessons.ToList().Select(l => l.name).Distinct().ToList();
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = context.Lessons.Where(l => l.name == item).ToList();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Lector_SubjectForm(dataGridView1.Rows[e.RowIndex].DataBoundItem as Lessons).ShowDialog();
        }

        private void CreateTestData()
        {
            Lessons[] data = new[]
            {
                new Lessons()
                {
                    name = "Maths"
                },
                new Lessons()
                {
                    name = "Computer Science"
                },
                new Lessons()
                {
                    name = "Sociology"
                },
            };
            var list = data.ToList();
            list.ForEach(d => d.date = System.DateTime.Now);
            context.Lessons.AddRange(list);
            context.SaveChanges();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //var emp = new Employee("John", "Doe", "123", new DateTime(), "lol", "memelogy");
            //employeeRepository.InsertEntity(emp);
            //employeeRepository.Save();
            //MessageBox.Show(employeeRepository.GetEntities().Count().ToString());
            //this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CreateTestData();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
