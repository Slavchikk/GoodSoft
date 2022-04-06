using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodSoft
{
    public partial class ParentsForm : Form
    {
        TraceCheck delet = new TraceCheck();
        public ParentsForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Parents_Click(object sender, EventArgs e)
        {
            MainMenu sf = new MainMenu();
            sf.Owner = this;
            sf.Show();
            this.Hide();
        }

        private void ParentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parentsDataSet.Parents". При необходимости она может быть перемещена или удалена.
            this.parentsTableAdapter.Fill(this.parentsDataSet.Parents);

        }

        private void SaveBtn_Parents_Click(object sender, EventArgs e)
        {
            this.parentsTableAdapter.Update(parentsDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            if (dr == DialogResult.OK)
            {
                delet.parentsDelete();
            }
        }

        private void SearchBtn_Parents_Click(object sender, EventArgs e)
        {
            SearchForm_Parents sf = new SearchForm_Parents();
            sf.Owner = this;
            sf.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
