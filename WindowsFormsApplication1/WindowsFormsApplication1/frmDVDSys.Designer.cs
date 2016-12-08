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
            this.mnuRegisterCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeregisterCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListDailyRentals = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(366, 24);
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
            this.mnuDVD.Size = new System.Drawing.Size(47, 20);
            this.mnuDVD.Text = "DVDs";
            // 
            // mnuRegisterDVD
            // 
            this.mnuRegisterDVD.Name = "mnuRegisterDVD";
            this.mnuRegisterDVD.Size = new System.Drawing.Size(143, 22);
            this.mnuRegisterDVD.Text = "Register DVD";
            this.mnuRegisterDVD.Click += new System.EventHandler(this.mnuRegisterDVD_Click);
            // 
            // mnuUpdateDVD
            // 
            this.mnuUpdateDVD.Name = "mnuUpdateDVD";
            this.mnuUpdateDVD.Size = new System.Drawing.Size(143, 22);
            this.mnuUpdateDVD.Text = "Update DVD";
            this.mnuUpdateDVD.Click += new System.EventHandler(this.mnuUpdateDVD_Click);
            // 
            // mnuRemoveDVD
            // 
            this.mnuRemoveDVD.Name = "mnuRemoveDVD";
            this.mnuRemoveDVD.Size = new System.Drawing.Size(143, 22);
            this.mnuRemoveDVD.Text = "Remove DVD";
            this.mnuRemoveDVD.Click += new System.EventHandler(this.mnuRemoveDVD_Click);
            // 
            // mnuListDVD
            // 
            this.mnuListDVD.Name = "mnuListDVD";
            this.mnuListDVD.Size = new System.Drawing.Size(143, 22);
            this.mnuListDVD.Text = "List DVD";
            this.mnuListDVD.Click += new System.EventHandler(this.mnuListDVD_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterCustomer,
            this.mnuUpdateCustomer,
            this.mnuDeregisterCustomer,
            this.lstCustomerList});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // mnuRegisterCustomer
            // 
            this.mnuRegisterCustomer.Name = "mnuRegisterCustomer";
            this.mnuRegisterCustomer.Size = new System.Drawing.Size(193, 22);
            this.mnuRegisterCustomer.Text = "Register Customer";
            this.mnuRegisterCustomer.Click += new System.EventHandler(this.mnuRegisterCustomer_Click);
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(193, 22);
            this.mnuUpdateCustomer.Text = "Update Customer";
            this.mnuUpdateCustomer.Click += new System.EventHandler(this.mnuUpdateCustomer_Click);
            // 
            // mnuDeregisterCustomer
            // 
            this.mnuDeregisterCustomer.Name = "mnuDeregisterCustomer";
            this.mnuDeregisterCustomer.Size = new System.Drawing.Size(193, 22);
            this.mnuDeregisterCustomer.Text = "De-Register Customer";
            this.mnuDeregisterCustomer.Click += new System.EventHandler(this.mnuDeregisterCustomer_Click);
            // 
            // lstCustomerList
            // 
            this.lstCustomerList.Name = "lstCustomerList";
            this.lstCustomerList.Size = new System.Drawing.Size(193, 22);
            this.lstCustomerList.Text = "List Customers Rentals";
            this.lstCustomerList.Click += new System.EventHandler(this.lstCustomerList_Click);
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRentDVD,
            this.mnuReturnDVD,
            this.mnuListDailyRentals});
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // mnuRentDVD
            // 
            this.mnuRentDVD.Name = "mnuRentDVD";
            this.mnuRentDVD.Size = new System.Drawing.Size(162, 22);
            this.mnuRentDVD.Text = "Rent DVD";
            this.mnuRentDVD.Click += new System.EventHandler(this.mnuRentDVD_Click);
            // 
            // mnuReturnDVD
            // 
            this.mnuReturnDVD.Name = "mnuReturnDVD";
            this.mnuReturnDVD.Size = new System.Drawing.Size(162, 22);
            this.mnuReturnDVD.Text = "Return DVD";
            this.mnuReturnDVD.Click += new System.EventHandler(this.mnuReturnDVD_Click);
            // 
            // mnuListDailyRentals
            // 
            this.mnuListDailyRentals.Name = "mnuListDailyRentals";
            this.mnuListDailyRentals.Size = new System.Drawing.Size(162, 22);
            this.mnuListDailyRentals.Text = "List Daily Rentals";
            this.mnuListDailyRentals.Click += new System.EventHandler(this.mnuListDailyRentals_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
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
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuListDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuDeregisterCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuRentDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuListDailyRentals;
        private System.Windows.Forms.ToolStripMenuItem lstCustomerList;
    }
}

