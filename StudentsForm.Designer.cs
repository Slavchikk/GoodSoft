namespace GoodSoft
{
    partial class StudentsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodparentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new GoodSoft.StudentsDataSet();
            this.studentTableAdapter = new GoodSoft.StudentsDataSetTableAdapters.StudentTableAdapter();
            this.BackBtn_Students = new System.Windows.Forms.Button();
            this.SaveBtn_Studets = new System.Windows.Forms.Button();
            this.SearchBtn_Students = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodstudentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn,
            this.kodspecDataGridViewTextBoxColumn,
            this.kodgroupDataGridViewTextBoxColumn,
            this.kodparentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // kodstudentDataGridViewTextBoxColumn
            // 
            this.kodstudentDataGridViewTextBoxColumn.DataPropertyName = "Kod_student";
            this.kodstudentDataGridViewTextBoxColumn.HeaderText = "Kod_student";
            this.kodstudentDataGridViewTextBoxColumn.Name = "kodstudentDataGridViewTextBoxColumn";
            this.kodstudentDataGridViewTextBoxColumn.Width = 75;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // otchestvoDataGridViewTextBoxColumn
            // 
            this.otchestvoDataGridViewTextBoxColumn.DataPropertyName = "Otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.HeaderText = "Otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.Name = "otchestvoDataGridViewTextBoxColumn";
            // 
            // kodspecDataGridViewTextBoxColumn
            // 
            this.kodspecDataGridViewTextBoxColumn.DataPropertyName = "Kod_spec";
            this.kodspecDataGridViewTextBoxColumn.HeaderText = "Kod_spec";
            this.kodspecDataGridViewTextBoxColumn.Name = "kodspecDataGridViewTextBoxColumn";
            this.kodspecDataGridViewTextBoxColumn.Width = 75;
            // 
            // kodgroupDataGridViewTextBoxColumn
            // 
            this.kodgroupDataGridViewTextBoxColumn.DataPropertyName = "Kod_group";
            this.kodgroupDataGridViewTextBoxColumn.HeaderText = "Kod_group";
            this.kodgroupDataGridViewTextBoxColumn.Name = "kodgroupDataGridViewTextBoxColumn";
            this.kodgroupDataGridViewTextBoxColumn.Width = 75;
            // 
            // kodparentsDataGridViewTextBoxColumn
            // 
            this.kodparentsDataGridViewTextBoxColumn.DataPropertyName = "Kod_parents";
            this.kodparentsDataGridViewTextBoxColumn.HeaderText = "Kod_parents";
            this.kodparentsDataGridViewTextBoxColumn.Name = "kodparentsDataGridViewTextBoxColumn";
            this.kodparentsDataGridViewTextBoxColumn.Width = 75;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // BackBtn_Students
            // 
            this.BackBtn_Students.Location = new System.Drawing.Point(12, 12);
            this.BackBtn_Students.Name = "BackBtn_Students";
            this.BackBtn_Students.Size = new System.Drawing.Size(94, 34);
            this.BackBtn_Students.TabIndex = 1;
            this.BackBtn_Students.Text = "Назад";
            this.BackBtn_Students.UseVisualStyleBackColor = true;
            this.BackBtn_Students.Click += new System.EventHandler(this.BackBtn_Students_Click);
            // 
            // SaveBtn_Studets
            // 
            this.SaveBtn_Studets.Location = new System.Drawing.Point(12, 341);
            this.SaveBtn_Studets.Name = "SaveBtn_Studets";
            this.SaveBtn_Studets.Size = new System.Drawing.Size(94, 34);
            this.SaveBtn_Studets.TabIndex = 2;
            this.SaveBtn_Studets.Text = "Сохранить";
            this.SaveBtn_Studets.UseVisualStyleBackColor = true;
            this.SaveBtn_Studets.Click += new System.EventHandler(this.SaveBtn_Studets_Click);
            // 
            // SearchBtn_Students
            // 
            this.SearchBtn_Students.Location = new System.Drawing.Point(136, 341);
            this.SearchBtn_Students.Name = "SearchBtn_Students";
            this.SearchBtn_Students.Size = new System.Drawing.Size(100, 34);
            this.SearchBtn_Students.TabIndex = 3;
            this.SearchBtn_Students.Text = "Найти";
            this.SearchBtn_Students.UseVisualStyleBackColor = true;
            this.SearchBtn_Students.Click += new System.EventHandler(this.SearchBtn_Students_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn_Students);
            this.Controls.Add(this.SaveBtn_Studets);
            this.Controls.Add(this.BackBtn_Students);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public StudentsDataSet studentsDataSet;
        public System.Windows.Forms.BindingSource studentBindingSource;
        public StudentsDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodparentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackBtn_Students;
        private System.Windows.Forms.Button SaveBtn_Studets;
        private System.Windows.Forms.Button SearchBtn_Students;
    }
}