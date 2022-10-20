using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreWinFormsApp1
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") {
                MessageBox.Show("Input user name");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Input password");
                return;
            }
            if (txtUsername.Text.ToLower() == "admin" && txtPassword.Text == "123")
            {
                this.Close();
            }
            else {
                MessageBox.Show("Invalid creds");
                return;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void LoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
