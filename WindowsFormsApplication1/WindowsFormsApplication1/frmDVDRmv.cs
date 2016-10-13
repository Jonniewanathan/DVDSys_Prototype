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
    public partial class frmDVDRmv : Form
    {
        private DVDSys_Menu parent;
        public frmDVDRmv()
        {
            InitializeComponent();
        }

        public frmDVDRmv(DVDSys_Menu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
            parent.Show();
        }

        private void frmDVDRmv_Load(object sender, EventArgs e)
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

        private void frmDVDRmv_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
