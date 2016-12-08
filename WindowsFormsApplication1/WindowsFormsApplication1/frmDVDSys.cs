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
    public partial class DVDSys_Menu : Form
    {
        public DVDSys_Menu()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRegisterDVD_Click(object sender, EventArgs e)
        {
            frmDVDReg formDVDReg = new frmDVDReg(this);
            this.Hide();
            formDVDReg.Show();
        }
        
        private void DVDSys_Menu_Load(object sender, EventArgs e)
        {

        }

        private void mnuUpdateDVD_Click(object sender, EventArgs e)
        {
            frmDVDUpd formDVDUpd = new frmDVDUpd(this);
            this.Hide();
            formDVDUpd.Show();
        }
               
        private void mnuRemoveDVD_Click(object sender, EventArgs e)
        {
            frmDVDRmv formDVDRmv = new frmDVDRmv(this);
            this.Hide();
            formDVDRmv.Show();
        }

        private void mnuListDVD_Click(object sender, EventArgs e)
        {
            frmDVDList formDVDlist = new frmDVDList(this);
            this.Hide();
            formDVDlist.Show();
        }

        private void DVDSys_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuRegisterCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerReg formCustomerReg = new frmCustomerReg(this);
            this.Hide();
            formCustomerReg.Show();
        }

        private void mnuUpdateCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerUpdate formCustomerUpdate = new frmCustomerUpdate(this);
            this.Hide();
            formCustomerUpdate.Show();
        }

        private void lstCustomerList_Click(object sender, EventArgs e)
        {
            frmCustomerList formCustomerList = new frmCustomerList(this);
            this.Hide();
            formCustomerList.Show();
        }

        private void mnuDeregisterCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDereg formCustomerDereg = new frmCustomerDereg(this);
            this.Hide();
            formCustomerDereg.Show();
        }

        private void mnuRentDVD_Click(object sender, EventArgs e)
        {
            frmRentDVD formRentDVD = new frmRentDVD(this);
            this.Hide();
            formRentDVD.Show();
        }

        private void mnuReturnDVD_Click(object sender, EventArgs e)
        {
            frmReturnDVD formReturnDVD = new frmReturnDVD(this);
            this.Hide();
            formReturnDVD.Show();
        }

        private void mnuListDailyRentals_Click(object sender, EventArgs e)
        {
            frmDailyRentals
        }
    }
}
