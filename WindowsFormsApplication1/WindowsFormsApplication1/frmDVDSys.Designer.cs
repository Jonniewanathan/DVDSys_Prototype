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
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDailyRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuRegisterDVD.Size = new System.Drawing.Size(152, 22);
            this.mnuRegisterDVD.Text = "Register DVD";
            this.mnuRegisterDVD.Click += new System.EventHandler(this.mnuRegisterDVD_Click);
            // 
            // mnuUpdateDVD
            // 
            this.mnuUpdateDVD.Name = "mnuUpdateDVD";
            this.mnuUpdateDVD.Size = new System.Drawing.Size(152, 22);
            this.mnuUpdateDVD.Text = "Update DVD";
            this.mnuUpdateDVD.Click += new System.EventHandler(this.mnuUpdateDVD_Click);
            // 
            // mnuRemoveDVD
            // 
            this.mnuRemoveDVD.Name = "mnuRemoveDVD";
            this.mnuRemoveDVD.Size = new System.Drawing.Size(152, 22);
            this.mnuRemoveDVD.Text = "Remove DVD";
            this.mnuRemoveDVD.Click += new System.EventHandler(this.mnuRemoveDVD_Click);
            // 
            // mnuListDVD
            // 
            this.mnuListDVD.Name = "mnuListDVD";
            this.mnuListDVD.Size = new System.Drawing.Size(152, 22);
            this.mnuListDVD.Text = "List DVD";
            this.mnuListDVD.Click += new System.EventHandler(this.mnuListDVD_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterCustomer,
            this.updateCustomerToolStripMenuItem,
            this.deRegisterCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // mnuRegisterCustomer
            // 
            this.mnuRegisterCustomer.Name = "mnuRegisterCustomer";
            this.mnuRegisterCustomer.Size = new System.Drawing.Size(190, 22);
            this.mnuRegisterCustomer.Text = "Register Customer";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            // 
            // deRegisterCustomerToolStripMenuItem
            // 
            this.deRegisterCustomerToolStripMenuItem.Name = "deRegisterCustomerToolStripMenuItem";
            this.deRegisterCustomerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deRegisterCustomerToolStripMenuItem.Text = "De-Register Customer";
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentDVDToolStripMenuItem,
            this.returnDVDToolStripMenuItem,
            this.listDailyRentalsToolStripMenuItem});
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // rentDVDToolStripMenuItem
            // 
            this.rentDVDToolStripMenuItem.Name = "rentDVDToolStripMenuItem";
            this.rentDVDToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rentDVDToolStripMenuItem.Text = "Rent DVD";
            // 
            // returnDVDToolStripMenuItem
            // 
            this.returnDVDToolStripMenuItem.Name = "returnDVDToolStripMenuItem";
            this.returnDVDToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.returnDVDToolStripMenuItem.Text = "Return DVD";
            // 
            // listDailyRentalsToolStripMenuItem
            // 
            this.listDailyRentalsToolStripMenuItem.Name = "listDailyRentalsToolStripMenuItem";
            this.listDailyRentalsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listDailyRentalsToolStripMenuItem.Text = "List Daily Rentals";
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
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deRegisterCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDailyRentalsToolStripMenuItem;
    }
}

