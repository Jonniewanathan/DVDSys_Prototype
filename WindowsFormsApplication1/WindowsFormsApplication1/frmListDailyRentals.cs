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
    public partial class frmListDailyRentals : Form
    {
        DVDSys_Menu parent;
        public frmListDailyRentals()
        {
            InitializeComponent();
        }

        public frmListDailyRentals(DVDSys_Menu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void frmListDailyRentals_Load(object sender, EventArgs e)
        {
            
            List<string> _items = new List<string>();
            lstDailyRentals.Visible = true;
            _items.Add("The Lord of the Rings, John Marshall");
            _items.Add("The Lion King, Frank Cusack");
            _items.Add("The King's Speech, James Brown");
            _items.Add("The Matrix, Frank Cusack");
            _items.Add("Taken, Frank Cusack");
            _items.Add("Taken 2 ,James Brown");
            _items.Add("Taken 3 ,James Brown");
            lstDailyRentals.Items.AddRange(new object[]
            {
                "The Lord of the Rings\t John Marshall",
                "The Lord of the Rings\t John Marshall",
                "The Lord of the Rings\t John Marshall",
                "The Lion King\t\t Frank Cusack",
                "The Matrix\t\t Frank Cusack",
                "Taken\t\t\t Frank Cusack",
                "Taken 3\t\t\t James Brown",
                "The Lord of the Rings\t John Marshall",
                "The Lion King\t\t Frank Cusack",
                "The King's Speech\t\t James Brown",
                "The Matrix\t\t Frank Cusack",
                "Taken\t\t\t Frank Cusack",
                "Taken 2\t\t\t James Brown",
                "Taken 3\t\t\t James Brown"
            });
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List sent to Printer");
        }
    }
}
