﻿using System;
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
    public partial class SearchForm_Students : Form
    {
        public SearchForm_Students()
        {
            InitializeComponent();
        }

        private void CloseBtn_Search_Students_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchBtn_Search_Students_Click(object sender, EventArgs e)
        {
            StudentsForm main = this.Owner as StudentsForm;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txb_Search_Students.Text))
                            {
                                main.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
