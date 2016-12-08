namespace WindowsFormsApplication1
{
    partial class frmRentDVD
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
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.btnSearchCust = new System.Windows.Forms.Button();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.lstBasket = new System.Windows.Forms.ListBox();
            this.grpDvdDetails = new System.Windows.Forms.GroupBox();
            this.lblRentalRate1 = new System.Windows.Forms.Label();
            this.lblGenre1 = new System.Windows.Forms.Label();
            this.lblAgeRating1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblDVDID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearchDVD = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.mnuStrip.SuspendLayout();
            this.grpDvdDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(902, 24);
            this.mnuStrip.TabIndex = 4;
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
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 59);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname";
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Location = new System.Drawing.Point(62, 51);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(124, 20);
            this.txtSearchCust.TabIndex = 6;
            // 
            // btnSearchCust
            // 
            this.btnSearchCust.Location = new System.Drawing.Point(192, 48);
            this.btnSearchCust.Name = "btnSearchCust";
            this.btnSearchCust.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCust.TabIndex = 7;
            this.btnSearchCust.Text = "Search";
            this.btnSearchCust.UseVisualStyleBackColor = true;
            this.btnSearchCust.Click += new System.EventHandler(this.btnSearchCust_Click);
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.Location = new System.Drawing.Point(9, 99);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(244, 303);
            this.lstCustomer.TabIndex = 8;
            // 
            // lstBasket
            // 
            this.lstBasket.FormattingEnabled = true;
            this.lstBasket.Location = new System.Drawing.Point(673, 99);
            this.lstBasket.Name = "lstBasket";
            this.lstBasket.Size = new System.Drawing.Size(195, 303);
            this.lstBasket.TabIndex = 29;
            // 
            // grpDvdDetails
            // 
            this.grpDvdDetails.Controls.Add(this.lblRentalRate1);
            this.grpDvdDetails.Controls.Add(this.lblGenre1);
            this.grpDvdDetails.Controls.Add(this.lblAgeRating1);
            this.grpDvdDetails.Controls.Add(this.lblTitle1);
            this.grpDvdDetails.Controls.Add(this.lblDVDID);
            this.grpDvdDetails.Controls.Add(this.btnAdd);
            this.grpDvdDetails.Controls.Add(this.lblRate);
            this.grpDvdDetails.Controls.Add(this.lblGenre);
            this.grpDvdDetails.Controls.Add(this.lblAgeRating);
            this.grpDvdDetails.Controls.Add(this.lblTitle);
            this.grpDvdDetails.Location = new System.Drawing.Point(334, 99);
            this.grpDvdDetails.Name = "grpDvdDetails";
            this.grpDvdDetails.Size = new System.Drawing.Size(268, 301);
            this.grpDvdDetails.TabIndex = 35;
            this.grpDvdDetails.TabStop = false;
            this.grpDvdDetails.Text = "DVD details";
            // 
            // lblRentalRate1
            // 
            this.lblRentalRate1.AutoSize = true;
            this.lblRentalRate1.Location = new System.Drawing.Point(101, 142);
            this.lblRentalRate1.Name = "lblRentalRate1";
            this.lblRentalRate1.Size = new System.Drawing.Size(35, 13);
            this.lblRentalRate1.TabIndex = 22;
            this.lblRentalRate1.Text = "label1";
            // 
            // lblGenre1
            // 
            this.lblGenre1.AutoSize = true;
            this.lblGenre1.Location = new System.Drawing.Point(101, 116);
            this.lblGenre1.Name = "lblGenre1";
            this.lblGenre1.Size = new System.Drawing.Size(35, 13);
            this.lblGenre1.TabIndex = 21;
            this.lblGenre1.Text = "label1";
            // 
            // lblAgeRating1
            // 
            this.lblAgeRating1.AutoSize = true;
            this.lblAgeRating1.Location = new System.Drawing.Point(101, 88);
            this.lblAgeRating1.Name = "lblAgeRating1";
            this.lblAgeRating1.Size = new System.Drawing.Size(35, 13);
            this.lblAgeRating1.TabIndex = 20;
            this.lblAgeRating1.Text = "label1";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Location = new System.Drawing.Point(101, 62);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(35, 13);
            this.lblTitle1.TabIndex = 19;
            this.lblTitle1.Text = "label1";
            // 
            // lblDVDID
            // 
            this.lblDVDID.AutoSize = true;
            this.lblDVDID.Location = new System.Drawing.Point(37, 20);
            this.lblDVDID.Name = "lblDVDID";
            this.lblDVDID.Size = new System.Drawing.Size(50, 13);
            this.lblDVDID.TabIndex = 18;
            this.lblDVDID.Text = "DVD I.D.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(101, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 28);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(34, 143);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(64, 13);
            this.lblRate.TabIndex = 15;
            this.lblRate.Text = "Rental Rate";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(34, 116);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 13;
            this.lblGenre.Text = "Genre";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(35, 89);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(60, 13);
            this.lblAgeRating.TabIndex = 11;
            this.lblAgeRating.Text = "Age Rating";
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
            // btnSearchDVD
            // 
            this.btnSearchDVD.Location = new System.Drawing.Point(508, 48);
            this.btnSearchDVD.Name = "btnSearchDVD";
            this.btnSearchDVD.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDVD.TabIndex = 34;
            this.btnSearchDVD.Text = "Search";
            this.btnSearchDVD.UseVisualStyleBackColor = true;
            this.btnSearchDVD.Click += new System.EventHandler(this.btnSearchDVD_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(331, 59);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "DVD i.d.";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(378, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(124, 20);
            this.txtSearch.TabIndex = 32;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(729, 423);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 36;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // frmRentDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 481);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.grpDvdDetails);
            this.Controls.Add(this.btnSearchDVD);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstBasket);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.btnSearchCust);
            this.Controls.Add(this.txtSearchCust);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.mnuStrip);
            this.Name = "frmRentDVD";
            this.Text = "frmRentDVD";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.grpDvdDetails.ResumeLayout(false);
            this.grpDvdDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Button btnSearchCust;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.ListBox lstBasket;
        private System.Windows.Forms.GroupBox grpDvdDetails;
        private System.Windows.Forms.Label lblRentalRate1;
        private System.Windows.Forms.Label lblGenre1;
        private System.Windows.Forms.Label lblAgeRating1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblDVDID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearchDVD;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRent;
    }
}