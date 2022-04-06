using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            labelLogin.Text = GlobalValues.login;
        }



        Point lastPoint;

        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelForExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void labelForChangeLogin_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Сменить пользователя?",
                "Смена пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AuthorizationWindow authoWindow = new AuthorizationWindow();
                this.Hide();
                authoWindow.Show();
            }


        }

        private void SpecialnostBtn_MainMenu_Click(object sender, EventArgs e)
        {
            SpecialnostForm sf = new SpecialnostForm();
            sf.Owner = this;
            sf.Show();
            this.Hide();
        }

        

        private void GroupsBtn_MainMenu_Click(object sender, EventArgs e)
        {
            GroupsForm sf = new GroupsForm();
            sf.Owner = this;
            sf.Show();
            this.Hide();
        }

        private void ParentsBtn_MAinMenu_Click(object sender, EventArgs e)
        {
            ParentsForm sf = new ParentsForm();
            sf.Owner = this;
            sf.Show();
            this.Hide();
        }

        private void DocumentsBtn_MainMenu_Click(object sender, EventArgs e)
        {
            DocumentsForm sf = new DocumentsForm();
            sf.Owner = this;
            sf.Show();
            this.Hide();
        }

        private void StudentsBtn_MainMenu_Click(object sender, EventArgs e)
        {
            StudentsForm sn = new StudentsForm();
            sn.Owner = this;
            sn.Show();
            this.Hide();
        }
    }
}
