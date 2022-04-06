namespace GoodSoft
{
    partial class ParentsForm
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
            this.BackBtn_Parents = new System.Windows.Forms.Button();
            this.SaveBtn_Parents = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodparentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePerentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameParentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoParentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentsDataSet = new GoodSoft.ParentsDataSet();
            this.parentsTableAdapter = new GoodSoft.ParentsDataSetTableAdapters.ParentsTableAdapter();
            this.SearchBtn_Parents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn_Parents
            // 
            this.BackBtn_Parents.Location = new System.Drawing.Point(12, 18);
            this.BackBtn_Parents.Name = "BackBtn_Parents";
            this.BackBtn_Parents.Size = new System.Drawing.Size(94, 38);
            this.BackBtn_Parents.TabIndex = 0;
            this.BackBtn_Parents.Text = "Назад";
            this.BackBtn_Parents.UseVisualStyleBackColor = true;
            this.BackBtn_Parents.Click += new System.EventHandler(this.BackBtn_Parents_Click);
            // 
            // SaveBtn_Parents
            // 
            this.SaveBtn_Parents.Location = new System.Drawing.Point(12, 307);
            this.SaveBtn_Parents.Name = "SaveBtn_Parents";
            this.SaveBtn_Parents.Size = new System.Drawing.Size(94, 38);
            this.SaveBtn_Parents.TabIndex = 1;
            this.SaveBtn_Parents.Text = "Сохранить";
            this.SaveBtn_Parents.UseVisualStyleBackColor = true;
            this.SaveBtn_Parents.Click += new System.EventHandler(this.SaveBtn_Parents_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodparentsDataGridViewTextBoxColumn,
            this.namePerentDataGridViewTextBoxColumn,
            this.surnameParentDataGridViewTextBoxColumn,
            this.otchestvoParentDataGridViewTextBoxColumn,
            this.professionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 162);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // kodparentsDataGridViewTextBoxColumn
            // 
            this.kodparentsDataGridViewTextBoxColumn.DataPropertyName = "Kod_parents";
            this.kodparentsDataGridViewTextBoxColumn.HeaderText = "Kod_parents";
            this.kodparentsDataGridViewTextBoxColumn.Name = "kodparentsDataGridViewTextBoxColumn";
            this.kodparentsDataGridViewTextBoxColumn.Width = 75;
            // 
            // namePerentDataGridViewTextBoxColumn
            // 
            this.namePerentDataGridViewTextBoxColumn.DataPropertyName = "NamePerent";
            this.namePerentDataGridViewTextBoxColumn.HeaderText = "NamePerent";
            this.namePerentDataGridViewTextBoxColumn.Name = "namePerentDataGridViewTextBoxColumn";
            this.namePerentDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameParentDataGridViewTextBoxColumn
            // 
            this.surnameParentDataGridViewTextBoxColumn.DataPropertyName = "SurnameParent";
            this.surnameParentDataGridViewTextBoxColumn.HeaderText = "SurnameParent";
            this.surnameParentDataGridViewTextBoxColumn.Name = "surnameParentDataGridViewTextBoxColumn";
            this.surnameParentDataGridViewTextBoxColumn.Width = 125;
            // 
            // otchestvoParentDataGridViewTextBoxColumn
            // 
            this.otchestvoParentDataGridViewTextBoxColumn.DataPropertyName = "OtchestvoParent";
            this.otchestvoParentDataGridViewTextBoxColumn.HeaderText = "OtchestvoParent";
            this.otchestvoParentDataGridViewTextBoxColumn.Name = "otchestvoParentDataGridViewTextBoxColumn";
            this.otchestvoParentDataGridViewTextBoxColumn.Width = 125;
            // 
            // professionDataGridViewTextBoxColumn
            // 
            this.professionDataGridViewTextBoxColumn.DataPropertyName = "Profession";
            this.professionDataGridViewTextBoxColumn.HeaderText = "Profession";
            this.professionDataGridViewTextBoxColumn.Name = "professionDataGridViewTextBoxColumn";
            this.professionDataGridViewTextBoxColumn.Width = 150;
            // 
            // parentsBindingSource
            // 
            this.parentsBindingSource.DataMember = "Parents";
            this.parentsBindingSource.DataSource = this.parentsDataSet;
            // 
            // parentsDataSet
            // 
            this.parentsDataSet.DataSetName = "ParentsDataSet";
            this.parentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parentsTableAdapter
            // 
            this.parentsTableAdapter.ClearBeforeFill = true;
            // 
            // SearchBtn_Parents
            // 
            this.SearchBtn_Parents.Location = new System.Drawing.Point(154, 307);
            this.SearchBtn_Parents.Name = "SearchBtn_Parents";
            this.SearchBtn_Parents.Size = new System.Drawing.Size(100, 38);
            this.SearchBtn_Parents.TabIndex = 4;
            this.SearchBtn_Parents.Text = "Найти";
            this.SearchBtn_Parents.UseVisualStyleBackColor = true;
            this.SearchBtn_Parents.Click += new System.EventHandler(this.SearchBtn_Parents_Click);
            // 
            // ParentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn_Parents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaveBtn_Parents);
            this.Controls.Add(this.BackBtn_Parents);
            this.Name = "ParentsForm";
            this.Text = "ParentsForm";
            this.Load += new System.EventHandler(this.ParentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BackBtn_Parents;
        public System.Windows.Forms.Button SaveBtn_Parents;
        public System.Windows.Forms.DataGridView dataGridView1;
        public ParentsDataSet parentsDataSet;
        public System.Windows.Forms.BindingSource parentsBindingSource;
        public ParentsDataSetTableAdapters.ParentsTableAdapter parentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodparentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePerentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameParentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoParentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SearchBtn_Parents;
    }
}