using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            var user = BusinessController.Instance.FindBy<User>(u => u.Username == username && u.Password == password).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
            else
            {
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;

                this.Hide();
                new MainWindow().ShowDialog();
                this.Show();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BusinessController.Instance.CloseConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
