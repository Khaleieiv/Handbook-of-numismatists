using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handbook_of_numismatis
{
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 50);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            Db db = new Db();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else    
                MessageBox.Show("No");
            
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }
        Point lastPoint;
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

