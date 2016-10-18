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
    public partial class DVDSys_Menu : Form
    {
        public DVDSys_Menu()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRegisterDVD_Click(object sender, EventArgs e)
        {
            frmDVDReg formDVDReg = new frmDVDReg(this);
            this.Hide();
            formDVDReg.Show();
        }
        
        private void DVDSys_Menu_Load(object sender, EventArgs e)
        {

        }

        private void mnuUpdateDVD_Click(object sender, EventArgs e)
        {
            frmDVDUpd formDVDUpd = new frmDVDUpd(this);
            this.Hide();
            formDVDUpd.Show();
        }
               
        private void mnuRemoveDVD_Click(object sender, EventArgs e)
        {
            frmDVDRmv formDVDRmv = new frmDVDRmv(this);
            this.Hide();
            formDVDRmv.Show();
        }

        private void mnuListDVD_Click(object sender, EventArgs e)
        {
            frmDVDList formDVDlist = new frmDVDList(this);
            this.Hide();
            formDVDlist.Show();
        }

        private void DVDSys_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
