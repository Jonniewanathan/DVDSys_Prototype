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
    public partial class frmCustomerList : Form
    {
        DVDSys_Menu parent;
        public frmCustomerList()
        {
            InitializeComponent();
        }

        public frmCustomerList(DVDSys_Menu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> _items = new List<string>();
            _items.Add("John Marshall");
            _items.Add("Frank Cusack");
            _items.Add("James Brown");
            lstCustomer.DataSource = _items;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
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
            _items.Add("Matrix Reloaded");
            lstDVDlist.DataSource = _items;
        }
    }
}
