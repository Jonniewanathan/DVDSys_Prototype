using System;
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
    public partial class frmDVDUpd : Form
    {
        private DVDSys_Menu parent;
        public frmDVDUpd()
        {
            InitializeComponent();
        }

        public frmDVDUpd(DVDSys_Menu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //makes the group box visible after clicking the search button
            grpDvdDetails.Visible = true;
            lblDVDId.Text = txtSearch.Text;
        }

        private void frmDVDUpd_Load(object sender, EventArgs e)
        {
            grpDvdDetails.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Confirmed");

        }

        private void frmDVDUpd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
