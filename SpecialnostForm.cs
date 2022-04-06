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
    public partial class SpecialnostForm : Form
    {

        TraceCheck delet = new TraceCheck();
        public SpecialnostForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SpecialnostForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_31П_Проект_ДолгDataSet1.Specialnost". При необходимости она может быть перемещена или удалена.
            this.specialnostTableAdapter2.Fill(this._31П_Проект_ДолгDataSet1.Specialnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "specialnostDataSet.Specialnost". При необходимости она может быть перемещена или удалена.
            this.specialnostTableAdapter1.Fill(this.specialnostDataSet.Specialnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_31П_Проект_ДолгDataSet.Specialnost". При необходимости она может быть перемещена или удалена.
            this.specialnostTableAdapter.Fill(this._31П_Проект_ДолгDataSet.Specialnost);

        }

        private void BackBtn_Specialnost_Click(object sender, EventArgs e)
        {
            MainMenu sf = new MainMenu();
            sf.Owner = this;
            sf.Show();
            this.Hide();
        }

        private void SaveBtn_Specialnost_Click(object sender, EventArgs e)
        {
            this.specialnostTableAdapter.Update(_31П_Проект_ДолгDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            if(dr == DialogResult.OK)
            {
                delet.specDelete();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow_1(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
