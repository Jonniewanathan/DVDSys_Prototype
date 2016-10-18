namespace WindowsFormsApplication1
{
    partial class DVDSys_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDVD,
            this.customerToolStripMenuItem,
            this.rentalsToolStripMenuItem,
            this.financeToolStripMenuItem,
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(366, 29);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuDVD
            // 
            this.mnuDVD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterDVD,
            this.mnuUpdateDVD,
            this.mnuRemoveDVD,
            this.mnuListDVD});
            this.mnuDVD.Name = "mnuDVD";
            this.mnuDVD.Size = new System.Drawing.Size(61, 25);
            this.mnuDVD.Text = "DVDs";
            // 
            // mnuRegisterDVD
            // 
            this.mnuRegisterDVD.Name = "mnuRegisterDVD";
            this.mnuRegisterDVD.Size = new System.Drawing.Size(173, 26);
            this.mnuRegisterDVD.Text = "Register DVD";
            this.mnuRegisterDVD.Click += new System.EventHandler(this.mnuRegisterDVD_Click);
            // 
            // mnuUpdateDVD
            // 
            this.mnuUpdateDVD.Name = "mnuUpdateDVD";
            this.mnuUpdateDVD.Size = new System.Drawing.Size(173, 26);
            this.mnuUpdateDVD.Text = "Update DVD";
            this.mnuUpdateDVD.Click += new System.EventHandler(this.mnuUpdateDVD_Click);
            // 
            // mnuRemoveDVD
            // 
            this.mnuRemoveDVD.Name = "mnuRemoveDVD";
            this.mnuRemoveDVD.Size = new System.Drawing.Size(173, 26);
            this.mnuRemoveDVD.Text = "Remove DVD";
            this.mnuRemoveDVD.Click += new System.EventHandler(this.mnuRemoveDVD_Click);
            // 
            // mnuListDVD
            // 
            this.mnuListDVD.Name = "mnuListDVD";
            this.mnuListDVD.Size = new System.Drawing.Size(173, 26);
            this.mnuListDVD.Text = "List DVD";
            this.mnuListDVD.Click += new System.EventHandler(this.mnuListDVD_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.deRegisterCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // registerCustomerToolStripMenuItem
            // 
            this.registerCustomerToolStripMenuItem.Name = "registerCustomerToolStripMenuItem";
            this.registerCustomerToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.registerCustomerToolStripMenuItem.Text = "Register Customer";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            // 
            // deRegisterCustomerToolStripMenuItem
            // 
            this.deRegisterCustomerToolStripMenuItem.Name = "deRegisterCustomerToolStripMenuItem";
            this.deRegisterCustomerToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.deRegisterCustomerToolStripMenuItem.Text = "De-Register Customer";
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.financeToolStripMenuItem.Text = "Finance";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(46, 25);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // DVDSys_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 351);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "DVDSys_Menu";
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DVDSys_Menu_FormClosed);
            this.Load += new System.EventHandler(this.DVDSys_Menu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuDVD;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuListDVD;
        private System.Windows.Forms.ToolStripMenuItem registerCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deRegisterCustomerToolStripMenuItem;
    }
}

