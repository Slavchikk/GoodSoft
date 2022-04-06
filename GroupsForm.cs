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
    public partial class GroupsForm : Form
    {
        TraceCheck delet = new TraceCheck();
        public GroupsForm()
        {
            InitializeComponent();
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groupsDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.groupsDataSet.Groups);

        }

        private void BackBtn_Groups_Click(object sender, EventArgs e)
        {
            MainMenu sf = new MainMenu();
            sf.Owner = this;
            sf.Show();
            this.Hide();
        }

        private void SaveBtn_Groups_Click(object sender, EventArgs e)
        {
            this.groupsTableAdapter.Update(groupsDataSet);
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
                delet.groupDelete();
            }
        }
    }
}
