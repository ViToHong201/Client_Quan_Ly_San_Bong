using Quan_Ly_San_Bong.BLL;
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
    public partial class fSignUp : Form
    {
        public fSignUp()
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

        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "Config Password" | txtRePassword.Text == "")
            {

                txtRePassword.Text = "Password";
                txtRePassword.ForeColor = Color.Silver;
            }
        }

        private void txtRePassword_Enter(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "Config Password" | txtRePassword.Text == "Password"| txtRePassword.Text == "")
            {
                txtRePassword.Text = "";
                txtRePassword.PasswordChar = '*';
                txtRePassword.ForeColor = Color.Black;
            }
        }


        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone" | txtPhone.Text == "")
            {

                txtPhone.Text = "Phone";
                txtPhone.ForeColor = Color.Silver;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone" | txtPhone.Text == "")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        // Sự kiện sign up
        private void rjButton1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            string config_password = txtRePassword.Text;

            if (username == "Username" | password == "Password" | config_password == "Password" | config_password == "Config Password" | phone == "Phone" )
            {
                MessageBox.Show("Vui lòng điền đủ thông tin !", "Thông báo", MessageBoxButtons.OK);
                txtUser.Focus();
            }
            if (password != config_password)
            {
                MessageBox.Show("Mật khẩu và Mật khẩu xác nhận phải trùng nhau", "Thông báo", MessageBoxButtons.OK);
                txtRePassword.Clear();
                txtRePassword.Focus();
            }

            Account_BLL acc = new Account_BLL();
            if (acc.SignUp(username, password, phone))
            {
                MessageBox.Show("Đăng Ký Thành Công", "Success !!!", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông Báo", MessageBoxButtons.OK);
                txtUser.Focus();
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       
    }
}
