using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_San_Bong.BLL;

namespace Quan_Ly_San_Bong
{
    public partial class fLoginClient : Form
    {
        public fLoginClient()
        {
            InitializeComponent();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text =="Username" | txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username" | txtUser.Text == "")
            {
                txtUser.Text ="";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password"| txtPassword.Text == "")
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

        // Sự kiện login
        private void rjButton1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            Account_BLL account_bll = new Account_BLL();

            if (username == "Username" | password == "Password")
            {
                MessageBox.Show("Tài Khoản và Mật khẫu không được để trống !!!", "Thông Báo", MessageBoxButtons.OK);
                txtUser.Focus();
                return;
            }

            if (account_bll.Login(username, password))
            {
                fIndexClient f = new fIndexClient();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản và Mật khẫu không đúng !!!", "Thông Báo", MessageBoxButtons.OK);
                txtPassword.Clear();
                txtPassword.Focus();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fSignUp f = new fSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
