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
	public partial class Marks : Form
	{
		EbookContext context;
		MarkRepository repo;

		public Marks()
		{
			context = new EbookContext();
			repo = new MarkRepository(context);
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Marks_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = repo.GetEntities();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			mark m = new mark();
			repo.InsertEntity(m);
			repo.Save();

		}
	}
}
