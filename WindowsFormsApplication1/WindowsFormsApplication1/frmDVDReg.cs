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
    public partial class frmDVDReg : Form
    {
        private DVDSys_Menu parent;

        public frmDVDReg()
        {
            InitializeComponent();
        }
        public frmDVDReg(DVDSys_Menu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
            Parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmDVDReg_Load(object sender, EventArgs e)
        {
            cboAgeRating.Items.Add("General");
            cboAgeRating.Items.Add("Parental Guidance");
            cboAgeRating.Items.Add("12");
            cboAgeRating.Items.Add("15");
            cboAgeRating.Items.Add("18");

            cboGenre.Items.Add("Action");
            cboGenre.Items.Add("Adventure");
            cboGenre.Items.Add("Animation");
            cboGenre.Items.Add("Biography");
            cboGenre.Items.Add("Comedy");
            cboGenre.Items.Add("Crime");
            cboGenre.Items.Add("Children");
            cboGenre.Items.Add("Documentary");
            cboGenre.Items.Add("Drama");
            cboGenre.Items.Add("Family");
            cboGenre.Items.Add("Fantasy");
            cboGenre.Items.Add("History");
            cboGenre.Items.Add("Horror");
            cboGenre.Items.Add("Mystery");
            cboGenre.Items.Add("Romance");
            cboGenre.Items.Add("Sci - Fi");
            cboGenre.Items.Add("Thriller");
            cboGenre.Items.Add("War");
            cboGenre.Items.Add("Western");

            cboRetalRate.Items.Add("New Release");
            cboRetalRate.Items.Add("Old Release");
            cboRetalRate.Items.Add("New Childrens Release");
            cboRetalRate.Items.Add("Old Childrens Release");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submitted!");
            cboAgeRating.SelectedIndex = -1;
            cboGenre.SelectedIndex = -1;
            cboRetalRate.SelectedIndex = -1;
            txtTitle.Clear();
        }

        private void frmDVDReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
