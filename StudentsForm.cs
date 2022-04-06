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
    public partial class StudentsForm : Form
    {
        TraceCheck delet = new TraceCheck();
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.studentsDataSet.Student);

        }

        private void BackBtn_Students_Click(object sender, EventArgs e)
        {
            MainMenu sn = new MainMenu();
            sn.Owner = this;
            sn.Show();
            this.Hide();
        }

        private void SaveBtn_Studets_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Update(studentsDataSet);
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
                delet.studentDelete();
            }
        }

        private void SearchBtn_Students_Click(object sender, EventArgs e)
        {
            SearchForm_Students sf = new SearchForm_Students();
            sf.Owner = this;
            sf.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
