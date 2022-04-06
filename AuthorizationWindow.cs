using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodSoft
{

    public partial class AuthorizationWindow : Form
    {

        DataBase dataBase = new DataBase();
        TraceCheck check = new TraceCheck();
        public AuthorizationWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
           
           
                
            
        }

        private void textBoxForLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxForLogin.Text == "логин")
            {
            
                textBoxForLogin.Text = "";
                textBoxForLogin.ForeColor = Color.Black;
            }

            if (textBoxForPass.Text == "")
            {
                textBoxForPass.ForeColor = Color.Gray;
                textBoxForPass.Text = "пароль";
            }
        }

        private void textBoxForPass_MouseClick(object sender, MouseEventArgs e)
        {

            if (textBoxForPass.Text == "пароль")
            {
                textBoxForPass.Text = "";
                textBoxForPass.ForeColor = Color.Black;
                textBoxForPass.UseSystemPasswordChar = true;
            }

            if (textBoxForLogin.Text == "")
            {
                textBoxForLogin.ForeColor = Color.Gray;
                textBoxForLogin.Text = "логин";
            }
        }

        private void labelForExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void AuthorizationWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxForPass.Text == "")
            {
                textBoxForPass.ForeColor = Color.Gray;
                textBoxForPass.UseSystemPasswordChar = false;
                textBoxForPass.Text = "пароль";
            }
            if (textBoxForLogin.Text == "")
            {
                textBoxForLogin.ForeColor = Color.Gray;

                textBoxForLogin.Text = "логин";
            }

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            var login = textBoxForLogin.Text;
            var password = textBoxForPass.Text;

            if (login == "логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (password == "пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            string zapros = $"select Login from Klients where Login = '{login}' and Password = '{password}'";

            SqlCommand command = new SqlCommand(zapros, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {

                GlobalValues.login = login;
                this.Hide();
                MainMenu form = new MainMenu();
                form.Show();
                bool chk = true;
                check.checkTrace(chk);

            }
            else
            {
                bool chk = false;
                check.checkTrace(chk);
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        Point lastPoint;
        private void AuthorizationWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AuthorizationWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void textBoxForLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthorizationWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
