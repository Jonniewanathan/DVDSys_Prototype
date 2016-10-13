namespace WindowsFormsApplication1
{
    partial class frmDVDUpd
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpDvdDetails = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboRetalRate = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.cboAgeRating = new System.Windows.Forms.ComboBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDVDId = new System.Windows.Forms.Label();
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
            this.mnuStrip.Size = new System.Drawing.Size(293, 24);
            this.mnuStrip.TabIndex = 0;
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(50, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(124, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 45);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(180, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpDvdDetails
            // 
            this.grpDvdDetails.Controls.Add(this.lblDVDId);
            this.grpDvdDetails.Controls.Add(this.btnUpdate);
            this.grpDvdDetails.Controls.Add(this.txtTitle);
            this.grpDvdDetails.Controls.Add(this.cboRetalRate);
            this.grpDvdDetails.Controls.Add(this.cboGenre);
            this.grpDvdDetails.Controls.Add(this.cboAgeRating);
            this.grpDvdDetails.Controls.Add(this.lblRate);
            this.grpDvdDetails.Controls.Add(this.lblGenre);
            this.grpDvdDetails.Controls.Add(this.lblAgeRating);
            this.grpDvdDetails.Controls.Add(this.lblTitle);
            this.grpDvdDetails.Location = new System.Drawing.Point(12, 69);
            this.grpDvdDetails.Name = "grpDvdDetails";
            this.grpDvdDetails.Size = new System.Drawing.Size(268, 235);
            this.grpDvdDetails.TabIndex = 4;
            this.grpDvdDetails.TabStop = false;
            this.grpDvdDetails.Text = "DVD details";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(101, 60);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(149, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // cboRetalRate
            // 
            this.cboRetalRate.FormattingEnabled = true;
            this.cboRetalRate.Location = new System.Drawing.Point(101, 140);
            this.cboRetalRate.Name = "cboRetalRate";
            this.cboRetalRate.Size = new System.Drawing.Size(149, 21);
            this.cboRetalRate.TabIndex = 16;
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(101, 113);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(149, 21);
            this.cboGenre.TabIndex = 14;
            // 
            // cboAgeRating
            // 
            this.cboAgeRating.FormattingEnabled = true;
            this.cboAgeRating.Location = new System.Drawing.Point(101, 86);
            this.cboAgeRating.Name = "cboAgeRating";
            this.cboAgeRating.Size = new System.Drawing.Size(149, 21);
            this.cboAgeRating.TabIndex = 12;
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(101, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 28);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDVDId
            // 
            this.lblDVDId.AutoSize = true;
            this.lblDVDId.Location = new System.Drawing.Point(37, 20);
            this.lblDVDId.Name = "lblDVDId";
            this.lblDVDId.Size = new System.Drawing.Size(50, 13);
            this.lblDVDId.TabIndex = 18;
            this.lblDVDId.Text = "DVD I.D.";
            // 
            // frmDVDUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 325);
            this.Controls.Add(this.grpDvdDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmDVDUpd";
            this.Text = "Update DVD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDVDUpd_FormClosed);
            this.Load += new System.EventHandler(this.frmDVDUpd_Load);
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpDvdDetails;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboRetalRate;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.ComboBox cboAgeRating;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDVDId;
        private System.Windows.Forms.Button btnUpdate;
    }
}