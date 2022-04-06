namespace GoodSoft
{
    partial class SearchForm_Parents
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
            this.CloseBtn_Search_Parents = new System.Windows.Forms.Button();
            this.SearchBtn_Search_Parents = new System.Windows.Forms.Button();
            this.groupBox_Search_Parents = new System.Windows.Forms.GroupBox();
            this.txb_Search_Parents = new System.Windows.Forms.TextBox();
            this.label_Search_Parents = new System.Windows.Forms.Label();
            this.groupBox_Search_Parents.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn_Search_Parents
            // 
            this.CloseBtn_Search_Parents.Location = new System.Drawing.Point(250, 340);
            this.CloseBtn_Search_Parents.Name = "CloseBtn_Search_Parents";
            this.CloseBtn_Search_Parents.Size = new System.Drawing.Size(100, 29);
            this.CloseBtn_Search_Parents.TabIndex = 5;
            this.CloseBtn_Search_Parents.Text = "Закрыть";
            this.CloseBtn_Search_Parents.UseVisualStyleBackColor = true;
            this.CloseBtn_Search_Parents.Click += new System.EventHandler(this.CloseBtn_Search_Parents_Click);
            // 
            // SearchBtn_Search_Parents
            // 
            this.SearchBtn_Search_Parents.Location = new System.Drawing.Point(114, 340);
            this.SearchBtn_Search_Parents.Name = "SearchBtn_Search_Parents";
            this.SearchBtn_Search_Parents.Size = new System.Drawing.Size(100, 29);
            this.SearchBtn_Search_Parents.TabIndex = 4;
            this.SearchBtn_Search_Parents.Text = "Найти";
            this.SearchBtn_Search_Parents.UseVisualStyleBackColor = true;
            this.SearchBtn_Search_Parents.Click += new System.EventHandler(this.SearchBtn_Search_Parents_Click);
            // 
            // groupBox_Search_Parents
            // 
            this.groupBox_Search_Parents.Controls.Add(this.txb_Search_Parents);
            this.groupBox_Search_Parents.Controls.Add(this.label_Search_Parents);
            this.groupBox_Search_Parents.Location = new System.Drawing.Point(114, 82);
            this.groupBox_Search_Parents.Name = "groupBox_Search_Parents";
            this.groupBox_Search_Parents.Size = new System.Drawing.Size(572, 252);
            this.groupBox_Search_Parents.TabIndex = 3;
            this.groupBox_Search_Parents.TabStop = false;
            this.groupBox_Search_Parents.Text = "Поиск";
            // 
            // txb_Search_Parents
            // 
            this.txb_Search_Parents.Location = new System.Drawing.Point(61, 133);
            this.txb_Search_Parents.Name = "txb_Search_Parents";
            this.txb_Search_Parents.Size = new System.Drawing.Size(404, 20);
            this.txb_Search_Parents.TabIndex = 2;
            // 
            // label_Search_Parents
            // 
            this.label_Search_Parents.AutoSize = true;
            this.label_Search_Parents.Location = new System.Drawing.Point(105, 64);
            this.label_Search_Parents.Name = "label_Search_Parents";
            this.label_Search_Parents.Size = new System.Drawing.Size(231, 13);
            this.label_Search_Parents.TabIndex = 1;
            this.label_Search_Parents.Text = "Введите ФИО родителя или его профессию";
            // 
            // SearchForm_Parents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn_Search_Parents);
            this.Controls.Add(this.SearchBtn_Search_Parents);
            this.Controls.Add(this.groupBox_Search_Parents);
            this.Name = "SearchForm_Parents";
            this.Text = "SearchForm_Parents";
            this.groupBox_Search_Parents.ResumeLayout(false);
            this.groupBox_Search_Parents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn_Search_Parents;
        private System.Windows.Forms.Button SearchBtn_Search_Parents;
        private System.Windows.Forms.GroupBox groupBox_Search_Parents;
        private System.Windows.Forms.TextBox txb_Search_Parents;
        private System.Windows.Forms.Label label_Search_Parents;
    }
}