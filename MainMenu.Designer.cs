namespace GoodSoft
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.labelForExit = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelForChangeLogin = new System.Windows.Forms.Label();
            this.StudentsBtn_MainMenu = new System.Windows.Forms.Button();
            this.GroupsBtn_MainMenu = new System.Windows.Forms.Button();
            this.ParentsBtn_MAinMenu = new System.Windows.Forms.Button();
            this.DocumentsBtn_MainMenu = new System.Windows.Forms.Button();
            this.SpecialnostBtn_MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.Location = new System.Drawing.Point(179, 92);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(480, 55);
            this.labelMainMenu.TabIndex = 1;
            this.labelMainMenu.Text = "ГЛАВНОЕ В МЕНЮ";
            this.labelMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelForExit
            // 
            this.labelForExit.AutoSize = true;
            this.labelForExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForExit.Location = new System.Drawing.Point(802, 9);
            this.labelForExit.Name = "labelForExit";
            this.labelForExit.Size = new System.Drawing.Size(21, 20);
            this.labelForExit.TabIndex = 5;
            this.labelForExit.Text = "X";
            this.labelForExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelForExit_MouseClick);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(56, 19);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 18);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "логин";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 34);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelForChangeLogin
            // 
            this.labelForChangeLogin.AutoSize = true;
            this.labelForChangeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForChangeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForChangeLogin.Location = new System.Drawing.Point(12, 51);
            this.labelForChangeLogin.Name = "labelForChangeLogin";
            this.labelForChangeLogin.Size = new System.Drawing.Size(144, 13);
            this.labelForChangeLogin.TabIndex = 8;
            this.labelForChangeLogin.Text = "сменить пользователя";
            this.labelForChangeLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelForChangeLogin_MouseClick);
            // 
            // StudentsBtn_MainMenu
            // 
            this.StudentsBtn_MainMenu.Location = new System.Drawing.Point(366, 242);
            this.StudentsBtn_MainMenu.Name = "StudentsBtn_MainMenu";
            this.StudentsBtn_MainMenu.Size = new System.Drawing.Size(98, 31);
            this.StudentsBtn_MainMenu.TabIndex = 14;
            this.StudentsBtn_MainMenu.Text = "Студенты";
            this.StudentsBtn_MainMenu.Click += new System.EventHandler(this.StudentsBtn_MainMenu_Click);
            // 
            // GroupsBtn_MainMenu
            // 
            this.GroupsBtn_MainMenu.Location = new System.Drawing.Point(189, 348);
            this.GroupsBtn_MainMenu.Name = "GroupsBtn_MainMenu";
            this.GroupsBtn_MainMenu.Size = new System.Drawing.Size(98, 31);
            this.GroupsBtn_MainMenu.TabIndex = 10;
            this.GroupsBtn_MainMenu.Text = "Группы";
            this.GroupsBtn_MainMenu.UseVisualStyleBackColor = true;
            this.GroupsBtn_MainMenu.Click += new System.EventHandler(this.GroupsBtn_MainMenu_Click);
            // 
            // ParentsBtn_MAinMenu
            // 
            this.ParentsBtn_MAinMenu.Location = new System.Drawing.Point(556, 348);
            this.ParentsBtn_MAinMenu.Name = "ParentsBtn_MAinMenu";
            this.ParentsBtn_MAinMenu.Size = new System.Drawing.Size(103, 31);
            this.ParentsBtn_MAinMenu.TabIndex = 11;
            this.ParentsBtn_MAinMenu.Text = "Родители";
            this.ParentsBtn_MAinMenu.UseVisualStyleBackColor = true;
            this.ParentsBtn_MAinMenu.Click += new System.EventHandler(this.ParentsBtn_MAinMenu_Click);
            // 
            // DocumentsBtn_MainMenu
            // 
            this.DocumentsBtn_MainMenu.Location = new System.Drawing.Point(556, 285);
            this.DocumentsBtn_MainMenu.Name = "DocumentsBtn_MainMenu";
            this.DocumentsBtn_MainMenu.Size = new System.Drawing.Size(103, 31);
            this.DocumentsBtn_MainMenu.TabIndex = 12;
            this.DocumentsBtn_MainMenu.Text = "Документы";
            this.DocumentsBtn_MainMenu.UseVisualStyleBackColor = true;
            this.DocumentsBtn_MainMenu.Click += new System.EventHandler(this.DocumentsBtn_MainMenu_Click);
            // 
            // SpecialnostBtn_MainMenu
            // 
            this.SpecialnostBtn_MainMenu.Location = new System.Drawing.Point(189, 285);
            this.SpecialnostBtn_MainMenu.Name = "SpecialnostBtn_MainMenu";
            this.SpecialnostBtn_MainMenu.Size = new System.Drawing.Size(98, 31);
            this.SpecialnostBtn_MainMenu.TabIndex = 13;
            this.SpecialnostBtn_MainMenu.Text = "Специальности";
            this.SpecialnostBtn_MainMenu.UseVisualStyleBackColor = true;
            this.SpecialnostBtn_MainMenu.Click += new System.EventHandler(this.SpecialnostBtn_MainMenu_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 546);
            this.Controls.Add(this.SpecialnostBtn_MainMenu);
            this.Controls.Add(this.DocumentsBtn_MainMenu);
            this.Controls.Add(this.ParentsBtn_MAinMenu);
            this.Controls.Add(this.GroupsBtn_MainMenu);
            this.Controls.Add(this.StudentsBtn_MainMenu);
            this.Controls.Add(this.labelForChangeLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelForExit);
            this.Controls.Add(this.labelMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Label labelForExit;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelForChangeLogin;
        private System.Windows.Forms.Button StudentsBtn_MainMenu;
        private System.Windows.Forms.Button GroupsBtn_MainMenu;
        private System.Windows.Forms.Button ParentsBtn_MAinMenu;
        private System.Windows.Forms.Button DocumentsBtn_MainMenu;
        private System.Windows.Forms.Button SpecialnostBtn_MainMenu;
    }
}