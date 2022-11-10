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
    public partial class fIndexClient : Form
    {
        public fIndexClient()
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
            this.Refresh();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            fInfoCustomer f = new fInfoCustomer();
            f.ShowDialog();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            fCart f = new fCart();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            fDeposit f = new fDeposit();
            f.ShowDialog();
        }
    }
}
