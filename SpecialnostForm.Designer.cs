namespace GoodSoft
{
    partial class SpecialnostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.specialnostBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.specialnostDataSet = new GoodSoft.SpecialnostDataSet();
            this.specialnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._31П_Проект_ДолгDataSet = new GoodSoft._31П_Проект_ДолгDataSet();
            this.specialnostTableAdapter = new GoodSoft._31П_Проект_ДолгDataSetTableAdapters.SpecialnostTableAdapter();
            this.BackBtn_Specialnost = new System.Windows.Forms.Button();
            this.SaveBtn_Specialnost = new System.Windows.Forms.Button();
            this.specialnostTableAdapter1 = new GoodSoft.SpecialnostDataSetTableAdapters.SpecialnostTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._31П_Проект_ДолгDataSet1 = new GoodSoft._31П_Проект_ДолгDataSet1();
            this.specialnostBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.specialnostTableAdapter2 = new GoodSoft._31П_Проект_ДолгDataSet1TableAdapters.SpecialnostTableAdapter();
            this.kodspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._31П_Проект_ДолгDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._31П_Проект_ДолгDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // specialnostBindingSource1
            // 
            this.specialnostBindingSource1.DataMember = "Specialnost";
            this.specialnostBindingSource1.DataSource = this.specialnostDataSet;
            // 
            // specialnostDataSet
            // 
            this.specialnostDataSet.DataSetName = "SpecialnostDataSet";
            this.specialnostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialnostBindingSource
            // 
            this.specialnostBindingSource.DataMember = "Specialnost";
            this.specialnostBindingSource.DataSource = this._31П_Проект_ДолгDataSet;
            // 
            // _31П_Проект_ДолгDataSet
            // 
            this._31П_Проект_ДолгDataSet.DataSetName = "_31П_Проект_ДолгDataSet";
            this._31П_Проект_ДолгDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialnostTableAdapter
            // 
            this.specialnostTableAdapter.ClearBeforeFill = true;
            // 
            // BackBtn_Specialnost
            // 
            this.BackBtn_Specialnost.Location = new System.Drawing.Point(25, 4);
            this.BackBtn_Specialnost.Name = "BackBtn_Specialnost";
            this.BackBtn_Specialnost.Size = new System.Drawing.Size(97, 44);
            this.BackBtn_Specialnost.TabIndex = 1;
            this.BackBtn_Specialnost.Text = "Назад";
            this.BackBtn_Specialnost.UseVisualStyleBackColor = true;
            this.BackBtn_Specialnost.Click += new System.EventHandler(this.BackBtn_Specialnost_Click);
            // 
            // SaveBtn_Specialnost
            // 
            this.SaveBtn_Specialnost.Location = new System.Drawing.Point(25, 292);
            this.SaveBtn_Specialnost.Name = "SaveBtn_Specialnost";
            this.SaveBtn_Specialnost.Size = new System.Drawing.Size(97, 44);
            this.SaveBtn_Specialnost.TabIndex = 3;
            this.SaveBtn_Specialnost.Text = "Сохранить";
            this.SaveBtn_Specialnost.UseVisualStyleBackColor = true;
            this.SaveBtn_Specialnost.Click += new System.EventHandler(this.SaveBtn_Specialnost_Click);
            // 
            // specialnostTableAdapter1
            // 
            this.specialnostTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodspecDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.plataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specialnostBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(92, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 198);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow_1);
            // 
            // _31П_Проект_ДолгDataSet1
            // 
            this._31П_Проект_ДолгDataSet1.DataSetName = "_31П_Проект_ДолгDataSet1";
            this._31П_Проект_ДолгDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialnostBindingSource2
            // 
            this.specialnostBindingSource2.DataMember = "Specialnost";
            this.specialnostBindingSource2.DataSource = this._31П_Проект_ДолгDataSet1;
            // 
            // specialnostTableAdapter2
            // 
            this.specialnostTableAdapter2.ClearBeforeFill = true;
            // 
            // kodspecDataGridViewTextBoxColumn
            // 
            this.kodspecDataGridViewTextBoxColumn.DataPropertyName = "Kod_spec";
            this.kodspecDataGridViewTextBoxColumn.HeaderText = "Kod_spec";
            this.kodspecDataGridViewTextBoxColumn.Name = "kodspecDataGridViewTextBoxColumn";
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "Spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "Spec";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            // 
            // plataDataGridViewTextBoxColumn
            // 
            this.plataDataGridViewTextBoxColumn.DataPropertyName = "Plata";
            this.plataDataGridViewTextBoxColumn.HeaderText = "Plata";
            this.plataDataGridViewTextBoxColumn.Name = "plataDataGridViewTextBoxColumn";
            // 
            // SpecialnostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaveBtn_Specialnost);
            this.Controls.Add(this.BackBtn_Specialnost);
            this.Name = "SpecialnostForm";
            this.Text = "Специальности";
            this.Load += new System.EventHandler(this.SpecialnostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._31П_Проект_ДолгDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._31П_Проект_ДолгDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialnostBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _31П_Проект_ДолгDataSet _31П_Проект_ДолгDataSet;
        private System.Windows.Forms.BindingSource specialnostBindingSource;
        private _31П_Проект_ДолгDataSetTableAdapters.SpecialnostTableAdapter specialnostTableAdapter;
        private System.Windows.Forms.Button BackBtn_Specialnost;
        private System.Windows.Forms.Button SaveBtn_Specialnost;
        private SpecialnostDataSet specialnostDataSet;
        private System.Windows.Forms.BindingSource specialnostBindingSource1;
        private SpecialnostDataSetTableAdapters.SpecialnostTableAdapter specialnostTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _31П_Проект_ДолгDataSet1 _31П_Проект_ДолгDataSet1;
        private System.Windows.Forms.BindingSource specialnostBindingSource2;
        private _31П_Проект_ДолгDataSet1TableAdapters.SpecialnostTableAdapter specialnostTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataDataGridViewTextBoxColumn;
    }
}