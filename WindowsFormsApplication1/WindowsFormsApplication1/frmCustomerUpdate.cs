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
    public partial class frmCustomerUpdate : Form
    {
        DVDSys_Menu parent;
        public frmCustomerUpdate()
        {
            InitializeComponent();
        }

        public frmCustomerUpdate(DVDSys_Menu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstCustomer.Visible = true;
            List<string> _items = new List<string>();
            lstCustomer.Visible = true;
            _items.Add("John Marshall");
            _items.Add("Frank Cusack");
            _items.Add("James Brown");
            lstCustomer.DataSource = _items;
        }

        private void frmCustomerUpdate_Load(object sender, EventArgs e)
        {
            grpUpdateFrm.Visible = false;
            lstCustomer.Visible = false;
            cboTitle.Items.Add("Mr.");
            cboTitle.Items.Add("Mrs.");
            cboTitle.Items.Add("Miss");

        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpUpdateFrm.Visible = true;
            if(lstCustomer.SelectedIndex == 0)
            {
                cboTitle.SelectedIndex = 0;
                dtpDOB.Value = new DateTime(1990, 07, 17);
                txtSurname.Text = "Marshall";
                txtForename.Text = "John";
                txtPhoneNo.Text = "0667188888";
                txtEmail.Text = "Email@Email.com";
                txtAddress.Text = "Tralee";
            }
            else if(lstCustomer.SelectedIndex == 1)
            {
                cboTitle.SelectedIndex = 0;
                dtpDOB.Value = new DateTime(1988, 12, 10);
                txtSurname.Text = "Cusack";
                txtForename.Text = "Frank";
                txtPhoneNo.Text = "0667188888";
                txtEmail.Text = "Email@Email.com";
                txtAddress.Text = "Tralee";
            }
            else if(lstCustomer.SelectedIndex == 2)
            {
                cboTitle.SelectedIndex = 0;
                dtpDOB.Value = new DateTime(1995, 3, 25);
                txtSurname.Text = "Brown";
                txtForename.Text = "James";
                txtPhoneNo.Text = "0667188888";
                txtEmail.Text = "Email@Email.com";
                txtAddress.Text = "Tralee";
            }
            

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
    }
}
