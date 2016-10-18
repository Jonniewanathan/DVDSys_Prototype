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
    }
}
