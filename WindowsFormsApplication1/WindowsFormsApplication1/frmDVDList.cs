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
    public partial class frmDVDList : Form
    {
        private DVDSys_Menu parent;
        public frmDVDList()
        {
            InitializeComponent();
        }

        public frmDVDList(DVDSys_Menu Parent)
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

        private void frmDVDList_Load(object sender, EventArgs e)
        {
            lstDVDlist.Visible = false;

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
            cboGenre.Items.Add("Sci-Fi");
            cboGenre.Items.Add("Thriller");
            cboGenre.Items.Add("War");
            cboGenre.Items.Add("Western");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> _items = new List<string>();
            lstDVDlist.Visible = true;
            _items.Add("The Lord of the Rings: The Return of the King");
            _items.Add("The Lion King");
            _items.Add("The King's Speech");
            _items.Add("The Matrix");
            _items.Add("Taken");
            _items.Add("Taken 2");
            _items.Add("Taken 3");
            lstDVDlist.DataSource = _items;
            
        }

        private void frmDVDList_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
