namespace WindowsFormsApplication1
{
    partial class frmCustomerDereg
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblDOB1 = new System.Windows.Forms.Label();
            this.lblForename1 = new System.Windows.Forms.Label();
            this.lblSurname1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNo1 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.mnuStrip.SuspendLayout();
            this.grpCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(584, 24);
            this.mnuStrip.TabIndex = 3;
            this.mnuStrip.Text = "mnuStrip";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.lblEmail1);
            this.grpCustomerDetails.Controls.Add(this.lblAddress1);
            this.grpCustomerDetails.Controls.Add(this.lblPhoneNo1);
            this.grpCustomerDetails.Controls.Add(this.lblEmail);
            this.grpCustomerDetails.Controls.Add(this.lblAddress);
            this.grpCustomerDetails.Controls.Add(this.lblPhoneNo);
            this.grpCustomerDetails.Controls.Add(this.lblDOB1);
            this.grpCustomerDetails.Controls.Add(this.lblForename1);
            this.grpCustomerDetails.Controls.Add(this.lblSurname1);
            this.grpCustomerDetails.Controls.Add(this.lblTitle1);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerId);
            this.grpCustomerDetails.Controls.Add(this.btnRemove);
            this.grpCustomerDetails.Controls.Add(this.lblDOB);
            this.grpCustomerDetails.Controls.Add(this.lblForename);
            this.grpCustomerDetails.Controls.Add(this.lblSurname);
            this.grpCustomerDetails.Controls.Add(this.lblTitle);
            this.grpCustomerDetails.Location = new System.Drawing.Point(279, 99);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(268, 347);
            this.grpCustomerDetails.TabIndex = 12;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Custome Details";
            // 
            // lblDOB1
            // 
            this.lblDOB1.AutoSize = true;
            this.lblDOB1.Location = new System.Drawing.Point(101, 142);
            this.lblDOB1.Name = "lblDOB1";
            this.lblDOB1.Size = new System.Drawing.Size(0, 13);
            this.lblDOB1.TabIndex = 22;
            // 
            // lblForename1
            // 
            this.lblForename1.AutoSize = true;
            this.lblForename1.Location = new System.Drawing.Point(101, 116);
            this.lblForename1.Name = "lblForename1";
            this.lblForename1.Size = new System.Drawing.Size(0, 13);
            this.lblForename1.TabIndex = 21;
            // 
            // lblSurname1
            // 
            this.lblSurname1.AutoSize = true;
            this.lblSurname1.Location = new System.Drawing.Point(101, 88);
            this.lblSurname1.Name = "lblSurname1";
            this.lblSurname1.Size = new System.Drawing.Size(0, 13);
            this.lblSurname1.TabIndex = 20;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Location = new System.Drawing.Point(101, 62);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(0, 13);
            this.lblTitle1.TabIndex = 19;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(37, 20);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerId.TabIndex = 18;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(92, 304);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 28);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(34, 142);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 15;
            this.lblDOB.Text = "DOB";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(34, 116);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 13;
            this.lblForename.Text = "Forename";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(35, 89);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 11;
            this.lblSurname.Text = "Surname";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(34, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(197, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 52);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Surname";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(67, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(124, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(34, 166);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(58, 13);
            this.lblPhoneNo.TabIndex = 23;
            this.lblPhoneNo.Text = "Phone No.";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 192);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNo1
            // 
            this.lblPhoneNo1.AutoSize = true;
            this.lblPhoneNo1.Location = new System.Drawing.Point(101, 166);
            this.lblPhoneNo1.Name = "lblPhoneNo1";
            this.lblPhoneNo1.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneNo1.TabIndex = 26;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(101, 192);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(0, 13);
            this.lblAddress1.TabIndex = 27;
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Location = new System.Drawing.Point(101, 222);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(0, 13);
            this.lblEmail1.TabIndex = 28;
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.Location = new System.Drawing.Point(23, 85);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(168, 355);
            this.lstCustomer.TabIndex = 13;
            this.lstCustomer.SelectedIndexChanged += new System.EventHandler(this.lstCustomer_SelectedIndexChanged);
            // 
            // frmCustomerDereg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 467);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.mnuStrip);
            this.Name = "frmCustomerDereg";
            this.Text = "frmCustomerDereg";
            this.Load += new System.EventHandler(this.frmCustomerDereg_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblDOB1;
        private System.Windows.Forms.Label lblForename1;
        private System.Windows.Forms.Label lblSurname1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblPhoneNo1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ListBox lstCustomer;
    }
}