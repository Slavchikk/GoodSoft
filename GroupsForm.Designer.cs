namespace GoodSoft
{
    partial class GroupsForm
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
            this.BackBtn_Groups = new System.Windows.Forms.Button();
            this.SaveBtn_Groups = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupsDataSet = new GoodSoft.GroupsDataSet();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new GoodSoft.GroupsDataSetTableAdapters.GroupsTableAdapter();
            this.kodgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn_Groups
            // 
            this.BackBtn_Groups.Location = new System.Drawing.Point(25, 12);
            this.BackBtn_Groups.Name = "BackBtn_Groups";
            this.BackBtn_Groups.Size = new System.Drawing.Size(100, 38);
            this.BackBtn_Groups.TabIndex = 0;
            this.BackBtn_Groups.Text = "Назад";
            this.BackBtn_Groups.UseVisualStyleBackColor = true;
            this.BackBtn_Groups.Click += new System.EventHandler(this.BackBtn_Groups_Click);
            // 
            // SaveBtn_Groups
            // 
            this.SaveBtn_Groups.Location = new System.Drawing.Point(25, 308);
            this.SaveBtn_Groups.Name = "SaveBtn_Groups";
            this.SaveBtn_Groups.Size = new System.Drawing.Size(100, 38);
            this.SaveBtn_Groups.TabIndex = 1;
            this.SaveBtn_Groups.Text = "Сохранить";
            this.SaveBtn_Groups.UseVisualStyleBackColor = true;
            this.SaveBtn_Groups.Click += new System.EventHandler(this.SaveBtn_Groups_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodgroupDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.groupsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // groupsDataSet
            // 
            this.groupsDataSet.DataSetName = "GroupsDataSet";
            this.groupsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.groupsDataSet;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // kodgroupDataGridViewTextBoxColumn
            // 
            this.kodgroupDataGridViewTextBoxColumn.DataPropertyName = "Kod_group";
            this.kodgroupDataGridViewTextBoxColumn.HeaderText = "Kod_group";
            this.kodgroupDataGridViewTextBoxColumn.Name = "kodgroupDataGridViewTextBoxColumn";
            this.kodgroupDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Width = 150;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaveBtn_Groups);
            this.Controls.Add(this.BackBtn_Groups);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn_Groups;
        private System.Windows.Forms.Button SaveBtn_Groups;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GroupsDataSet groupsDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private GroupsDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
    }
}