using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_San_Bong
{
    public partial class Admin_fLogin : Form
    {
        public Admin_fLogin()
        {
            InitializeComponent();
        }


        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username" | txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username" | txtUser.Text == "")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password" | txtPassword.Text == "")
            {

                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password" | txtPassword.Text == "")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fSignUp f = new fSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
