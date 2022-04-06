namespace GoodSoft
{
    partial class DocumentsForm
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
            this.SaveBtn_Documents = new System.Windows.Forms.Button();
            this.BackBtn_Documents = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.documentsDataSet = new GoodSoft.DocumentsDataSet();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsTableAdapter = new GoodSoft.DocumentsDataSetTableAdapters.DocumentsTableAdapter();
            this.koddocumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaOplatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOplatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn_Documents
            // 
            this.SaveBtn_Documents.Location = new System.Drawing.Point(12, 264);
            this.SaveBtn_Documents.Name = "SaveBtn_Documents";
            this.SaveBtn_Documents.Size = new System.Drawing.Size(90, 38);
            this.SaveBtn_Documents.TabIndex = 1;
            this.SaveBtn_Documents.Text = "Сохранить";
            this.SaveBtn_Documents.UseVisualStyleBackColor = true;
            this.SaveBtn_Documents.Click += new System.EventHandler(this.SaveBtn_Documents_Click);
            // 
            // BackBtn_Documents
            // 
            this.BackBtn_Documents.Location = new System.Drawing.Point(12, 12);
            this.BackBtn_Documents.Name = "BackBtn_Documents";
            this.BackBtn_Documents.Size = new System.Drawing.Size(90, 38);
            this.BackBtn_Documents.TabIndex = 2;
            this.BackBtn_Documents.Text = "Назад";
            this.BackBtn_Documents.UseVisualStyleBackColor = true;
            this.BackBtn_Documents.Click += new System.EventHandler(this.BackBtn_Documents_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.koddocumentsDataGridViewTextBoxColumn,
            this.kodspecDataGridViewTextBoxColumn,
            this.kodstudentDataGridViewTextBoxColumn,
            this.summaOplatDataGridViewTextBoxColumn,
            this.dateOplatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // documentsDataSet
            // 
            this.documentsDataSet.DataSetName = "DocumentsDataSet";
            this.documentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.documentsDataSet;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // koddocumentsDataGridViewTextBoxColumn
            // 
            this.koddocumentsDataGridViewTextBoxColumn.DataPropertyName = "Kod_documents";
            this.koddocumentsDataGridViewTextBoxColumn.HeaderText = "Kod_documents";
            this.koddocumentsDataGridViewTextBoxColumn.Name = "koddocumentsDataGridViewTextBoxColumn";
            this.koddocumentsDataGridViewTextBoxColumn.Width = 75;
            // 
            // kodspecDataGridViewTextBoxColumn
            // 
            this.kodspecDataGridViewTextBoxColumn.DataPropertyName = "Kod_spec";
            this.kodspecDataGridViewTextBoxColumn.HeaderText = "Kod_spec";
            this.kodspecDataGridViewTextBoxColumn.Name = "kodspecDataGridViewTextBoxColumn";
            this.kodspecDataGridViewTextBoxColumn.Width = 75;
            // 
            // kodstudentDataGridViewTextBoxColumn
            // 
            this.kodstudentDataGridViewTextBoxColumn.DataPropertyName = "Kod_student";
            this.kodstudentDataGridViewTextBoxColumn.HeaderText = "Kod_student";
            this.kodstudentDataGridViewTextBoxColumn.Name = "kodstudentDataGridViewTextBoxColumn";
            this.kodstudentDataGridViewTextBoxColumn.Width = 75;
            // 
            // summaOplatDataGridViewTextBoxColumn
            // 
            this.summaOplatDataGridViewTextBoxColumn.DataPropertyName = "SummaOplat";
            this.summaOplatDataGridViewTextBoxColumn.HeaderText = "SummaOplat";
            this.summaOplatDataGridViewTextBoxColumn.Name = "summaOplatDataGridViewTextBoxColumn";
            // 
            // dateOplatDataGridViewTextBoxColumn
            // 
            this.dateOplatDataGridViewTextBoxColumn.DataPropertyName = "DateOplat";
            this.dateOplatDataGridViewTextBoxColumn.HeaderText = "DateOplat";
            this.dateOplatDataGridViewTextBoxColumn.Name = "dateOplatDataGridViewTextBoxColumn";
            // 
            // DocumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn_Documents);
            this.Controls.Add(this.SaveBtn_Documents);
            this.Name = "DocumentsForm";
            this.Text = "DocumentsForm";
            this.Load += new System.EventHandler(this.DocumentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveBtn_Documents;
        private System.Windows.Forms.Button BackBtn_Documents;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DocumentsDataSet documentsDataSet;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private DocumentsDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn koddocumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaOplatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOplatDataGridViewTextBoxColumn;
    }
}