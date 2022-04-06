namespace GoodSoft
{
    partial class SearchForm_Students
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
            this.groupBox_Search_Students = new System.Windows.Forms.GroupBox();
            this.label_Search_Students = new System.Windows.Forms.Label();
            this.SearchBtn_Search_Students = new System.Windows.Forms.Button();
            this.CloseBtn_Search_Students = new System.Windows.Forms.Button();
            this.txb_Search_Students = new System.Windows.Forms.TextBox();
            this.groupBox_Search_Students.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Search_Students
            // 
            this.groupBox_Search_Students.Controls.Add(this.txb_Search_Students);
            this.groupBox_Search_Students.Controls.Add(this.label_Search_Students);
            this.groupBox_Search_Students.Location = new System.Drawing.Point(54, 79);
            this.groupBox_Search_Students.Name = "groupBox_Search_Students";
            this.groupBox_Search_Students.Size = new System.Drawing.Size(572, 252);
            this.groupBox_Search_Students.TabIndex = 0;
            this.groupBox_Search_Students.TabStop = false;
            this.groupBox_Search_Students.Text = "Поиск";
            // 
            // label_Search_Students
            // 
            this.label_Search_Students.AutoSize = true;
            this.label_Search_Students.Location = new System.Drawing.Point(105, 64);
            this.label_Search_Students.Name = "label_Search_Students";
            this.label_Search_Students.Size = new System.Drawing.Size(291, 13);
            this.label_Search_Students.TabIndex = 1;
            this.label_Search_Students.Text = "Введите ФИО студента, код группы или специальности";
            // 
            // SearchBtn_Search_Students
            // 
            this.SearchBtn_Search_Students.Location = new System.Drawing.Point(54, 337);
            this.SearchBtn_Search_Students.Name = "SearchBtn_Search_Students";
            this.SearchBtn_Search_Students.Size = new System.Drawing.Size(100, 29);
            this.SearchBtn_Search_Students.TabIndex = 1;
            this.SearchBtn_Search_Students.Text = "Найти";
            this.SearchBtn_Search_Students.UseVisualStyleBackColor = true;
            this.SearchBtn_Search_Students.Click += new System.EventHandler(this.SearchBtn_Search_Students_Click);
            // 
            // CloseBtn_Search_Students
            // 
            this.CloseBtn_Search_Students.Location = new System.Drawing.Point(190, 337);
            this.CloseBtn_Search_Students.Name = "CloseBtn_Search_Students";
            this.CloseBtn_Search_Students.Size = new System.Drawing.Size(100, 29);
            this.CloseBtn_Search_Students.TabIndex = 2;
            this.CloseBtn_Search_Students.Text = "Закрыть";
            this.CloseBtn_Search_Students.UseVisualStyleBackColor = true;
            this.CloseBtn_Search_Students.Click += new System.EventHandler(this.CloseBtn_Search_Students_Click);
            // 
            // txb_Search_Students
            // 
            this.txb_Search_Students.Location = new System.Drawing.Point(61, 133);
            this.txb_Search_Students.Name = "txb_Search_Students";
            this.txb_Search_Students.Size = new System.Drawing.Size(404, 20);
            this.txb_Search_Students.TabIndex = 2;
            // 
            // SearchForm_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn_Search_Students);
            this.Controls.Add(this.SearchBtn_Search_Students);
            this.Controls.Add(this.groupBox_Search_Students);
            this.Name = "SearchForm_Students";
            this.Text = "SearchForm_Students";
            this.groupBox_Search_Students.ResumeLayout(false);
            this.groupBox_Search_Students.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Search_Students;
        private System.Windows.Forms.Label label_Search_Students;
        private System.Windows.Forms.TextBox txb_Search_Students;
        private System.Windows.Forms.Button SearchBtn_Search_Students;
        private System.Windows.Forms.Button CloseBtn_Search_Students;
    }
}