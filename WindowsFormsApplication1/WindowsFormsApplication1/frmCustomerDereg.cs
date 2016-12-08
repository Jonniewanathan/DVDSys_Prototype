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
    public partial class frmCustomerDereg : Form
    {
        DVDSys_Menu parent;
        public frmCustomerDereg()
        {
            InitializeComponent();
        }

        public frmCustomerDereg(DVDSys_Menu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void frmCustomerDereg_Load(object sender, EventArgs e)
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Removed");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            List<string> _items = new List<string>();
            _items.Add("John Marshall");
            _items.Add("Frank Cusack");
            _items.Add("James Brown");
            lstCustomer.DataSource = _items;
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedIndex == 0)
            {
                lblCustomerId.Text = "1";
                lblDOB1.Text = new DateTime(1990, 07, 17).ToString();
                lblSurname1.Text = "Marshall";
                lblForename1.Text = "John";
                lblPhoneNo1.Text = "0667188888";
                lblEmail1.Text = "Email@Email.com";
                lblAddress1.Text = "Tralee";
            }
            else if (lstCustomer.SelectedIndex == 1)
            {
                lblCustomerId.Text = "2";
                lblDOB1.Text = new DateTime(1988, 12, 10).ToString();
                lblSurname1.Text = "Cusack";
                lblForename1.Text = "Frank";
                lblPhoneNo1.Text = "0667188888";
                lblEmail1.Text = "Email@Email.com";
                lblAddress1.Text = "Tralee";
            }
            else if (lstCustomer.SelectedIndex == 2)
            {
                lblCustomerId.Text = "3";
                lblDOB1.Text = new DateTime(1992, 02, 22).ToString();
                lblSurname1.Text = "Brown";
                lblForename1.Text = "James";
                lblPhoneNo1.Text = "0667188888";
                lblEmail1.Text = "Email@Email.com";
                lblAddress1.Text = "Tralee";
            }
        }
    }
}
