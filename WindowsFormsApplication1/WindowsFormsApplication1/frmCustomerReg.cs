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
    public partial class frmCustomerReg : Form
    {
        private DVDSys_Menu parent;
        public frmCustomerReg()
        {
            InitializeComponent();
        }

        public frmCustomerReg(DVDSys_Menu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void frmCustomerReg_Load(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Registered");
        }
    }
}
