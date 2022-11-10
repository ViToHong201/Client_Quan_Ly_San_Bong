﻿using System;
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
    public partial class fCart : Form
    {
        public fCart()
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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            fInfoCustomer f = new fInfoCustomer();
            f.ShowDialog();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        #endregion

    
    }
}
