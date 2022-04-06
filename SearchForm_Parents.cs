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
    public partial class SearchForm_Parents : Form
    {
        public SearchForm_Parents()
        {
            InitializeComponent();
        }

        private void CloseBtn_Search_Parents_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchBtn_Search_Parents_Click(object sender, EventArgs e)
        {
            ParentsForm main = this.Owner as ParentsForm;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txb_Search_Parents.Text))
                            {
                                main.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
