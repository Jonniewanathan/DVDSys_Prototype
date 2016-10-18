﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmDVDRmv : Form
    {
        private DVDSys_Menu parent;
        public frmDVDRmv()
        {
            InitializeComponent();
        }

        public frmDVDRmv(DVDSys_Menu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
            parent.Show();
        }

        private void frmDVDRmv_Load(object sender, EventArgs e)
        {
            grpDvdDetails.Visible = false;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDVDRmv_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DVD now Unavailable");

            grpDvdDetails.Visible = false;

            cboAgeRating.SelectedIndex = -1;
            cboGenre.SelectedIndex = -1;
            cboRetalRate.SelectedIndex = -1;
            nrmQuantity.Value = 0;
            txtTitle.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpDvdDetails.Visible = true;
            lblDVDId.Text = txtSearch.Text;
        }
    }
}
