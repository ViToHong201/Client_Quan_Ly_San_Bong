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
    public partial class fInfoCustomer : Form
    {
        public fInfoCustomer()
        {
            InitializeComponent();

        }

        #region Header button

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ChangeStatus(!txtName.Enabled);
            if (txtName.Enabled)
            {
                btnEdit.Text = "Lưu";
                rjButton1.Show();
                txtUsername.Hide();
                txtPassword.Hide();

            }
            else
            {
                btnEdit.Text = "Sửa";
                rjButton1.Hide();
                HideTextBox();

            }
        }

        void ChangeStatus(bool sta)
        {
            txtName.Enabled = sta;
            txtPhone.Enabled = sta;
           
        }

        void HideTextBox()
        {
            txtUsername.Hide();
            txtPassword.Hide();
            txtConfigPassword.Hide();

        }
        private void fInfoCustomer_Load(object sender, EventArgs e)
        {
            HideTextBox();
            txtUsername.Show();
            txtPassword.Show();
            rjButton1.Hide();

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            txtUsername.Show();
            txtPassword.Show();
            txtConfigPassword.Show();

            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtConfigPassword.Enabled = true;
            rjButton1.Hide();
        }

        private void txtName_Load(object sender, EventArgs e)
        {

        }

        //private void txtPhone_Load(object sender, EventArgs e)
        //{
       

    //    }
    //}

        //private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //        //if (e.KeyChar != 'b')
        //    //{
        //    //    //allows just number keys
        //    //    e.Handled = !char.IsNumber(e.KeyChar);
        //    //}

           
            
        //}

        //private void txtPhone_SizeChanged(object sender, EventArgs e)
        //{
        //    string tString = txtPhone.Text;
        //    if (tString.Trim() == "") return;
        //    for (int i = 0; i < tString.Length; i++)
        //    {
        //        if (!char.IsNumber(tString[i]))
        //        {

        //            txtPhone.Text = "";
        //            return;
        //        }
        //    }
        //}
    }
}
