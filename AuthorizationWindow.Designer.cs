namespace GoodSoft
{
    partial class AuthorizationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationWindow));
            this.labelAutho = new System.Windows.Forms.Label();
            this.textBoxForLogin = new System.Windows.Forms.TextBox();
            this.textBoxForPass = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelForExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAutho
            // 
            this.labelAutho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAutho.AutoSize = true;
            this.labelAutho.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutho.Location = new System.Drawing.Point(147, 161);
            this.labelAutho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutho.Name = "labelAutho";
            this.labelAutho.Size = new System.Drawing.Size(496, 69);
            this.labelAutho.TabIndex = 0;
            this.labelAutho.Text = "АВТОРИZАЦИЯ";
            this.labelAutho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxForLogin
            // 
            this.textBoxForLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxForLogin.Location = new System.Drawing.Point(283, 270);
            this.textBoxForLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxForLogin.Name = "textBoxForLogin";
            this.textBoxForLogin.Size = new System.Drawing.Size(244, 30);
            this.textBoxForLogin.TabIndex = 1;
            this.textBoxForLogin.TabStop = false;
            this.textBoxForLogin.Text = "логин";
            this.textBoxForLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxForLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxForLogin_MouseClick);
            this.textBoxForLogin.TextChanged += new System.EventHandler(this.textBoxForLogin_TextChanged);
            // 
            // textBoxForPass
            // 
            this.textBoxForPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxForPass.Location = new System.Drawing.Point(283, 313);
            this.textBoxForPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxForPass.Name = "textBoxForPass";
            this.textBoxForPass.Size = new System.Drawing.Size(244, 30);
            this.textBoxForPass.TabIndex = 2;
            this.textBoxForPass.TabStop = false;
            this.textBoxForPass.Text = "пароль";
            this.textBoxForPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxForPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxForPass_MouseClick);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(332, 373);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(145, 39);
            this.buttonEnter.TabIndex = 3;
            this.buttonEnter.Text = "Залететь!";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelForExit
            // 
            this.labelForExit.AutoSize = true;
            this.labelForExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForExit.Location = new System.Drawing.Point(767, 11);
            this.labelForExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForExit.Name = "labelForExit";
            this.labelForExit.Size = new System.Drawing.Size(27, 25);
            this.labelForExit.TabIndex = 4;
            this.labelForExit.Text = "X";
            this.labelForExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelForExit_MouseClick);
            // 
            // AuthorizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 554);
            this.Controls.Add(this.labelForExit);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxForPass);
            this.Controls.Add(this.textBoxForLogin);
            this.Controls.Add(this.labelAutho);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AuthorizationWindow";
            this.Text = "AuthorizationWindow";
            this.Load += new System.EventHandler(this.AuthorizationWindow_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AuthorizationWindow_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAutho;
        private System.Windows.Forms.TextBox textBoxForLogin;
        private System.Windows.Forms.TextBox textBoxForPass;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelForExit;
    }
}