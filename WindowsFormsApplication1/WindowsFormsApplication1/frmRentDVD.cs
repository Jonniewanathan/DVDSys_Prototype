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
    public partial class frmRentDVD : Form
    {
        DVDSys_Menu parent;
        List<string> _dvd = new List<string>();
        public frmRentDVD()
        {
            InitializeComponent();
        }

        public frmRentDVD(DVDSys_Menu Parent)
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

        private void btnSearchCust_Click(object sender, EventArgs e)
        {
            List<string> _items = new List<string>();
            _items.Add("John Marshall");
            _items.Add("Frank Cusack");
            _items.Add("James Brown");
            lstCustomer.DataSource = _items;
        }

        private void btnSearchDVD_Click(object sender, EventArgs e)
        {
            lblDVDID.Text = txtSearch.Text;
            lblTitle1.Text = "The Matrix";
            lblGenre1.Text = "Action";
            lblAgeRating1.Text = "18";
            lblRentalRate1.Text = "Old Release";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _dvd.Add(lblTitle1.Text);
            lstBasket.DataSource = _dvd;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DVDs Have Been Rented");
        }
    }
}
