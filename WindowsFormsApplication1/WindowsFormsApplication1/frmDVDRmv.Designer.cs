﻿namespace WindowsFormsApplication1
{
    partial class frmDVDRmv
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
            this.grpDvdDetails = new System.Windows.Forms.GroupBox();
            this.lblRentalRate1 = new System.Windows.Forms.Label();
            this.lblGenre1 = new System.Windows.Forms.Label();
            this.lblAgeRating1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblDVDId = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.mnuStrip.Size = new System.Drawing.Size(347, 24);
            this.mnuStrip.TabIndex = 1;
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
            // grpDvdDetails
            // 
            this.grpDvdDetails.Controls.Add(this.lblRentalRate1);
            this.grpDvdDetails.Controls.Add(this.lblGenre1);
            this.grpDvdDetails.Controls.Add(this.lblAgeRating1);
            this.grpDvdDetails.Controls.Add(this.lblTitle1);
            this.grpDvdDetails.Controls.Add(this.lblDVDId);
            this.grpDvdDetails.Controls.Add(this.btnRemove);
            this.grpDvdDetails.Controls.Add(this.lblRate);
            this.grpDvdDetails.Controls.Add(this.lblGenre);
            this.grpDvdDetails.Controls.Add(this.lblAgeRating);
            this.grpDvdDetails.Controls.Add(this.lblTitle);
            this.grpDvdDetails.Location = new System.Drawing.Point(16, 68);
            this.grpDvdDetails.Name = "grpDvdDetails";
            this.grpDvdDetails.Size = new System.Drawing.Size(268, 301);
            this.grpDvdDetails.TabIndex = 8;
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
            // lblDVDId
            // 
            this.lblDVDId.AutoSize = true;
            this.lblDVDId.Location = new System.Drawing.Point(37, 20);
            this.lblDVDId.Name = "lblDVDId";
            this.lblDVDId.Size = new System.Drawing.Size(50, 13);
            this.lblDVDId.TabIndex = 18;
            this.lblDVDId.Text = "DVD I.D.";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(101, 231);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 28);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(184, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "DVD i.d.";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(54, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(124, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // frmDVDRmv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 381);
            this.Controls.Add(this.grpDvdDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.mnuStrip);
            this.Name = "frmDVDRmv";
            this.Text = "Remove DVD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDVDRmv_FormClosed);
            this.Load += new System.EventHandler(this.frmDVDRmv_Load);
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
        private System.Windows.Forms.GroupBox grpDvdDetails;
        private System.Windows.Forms.Label lblDVDId;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRentalRate1;
        private System.Windows.Forms.Label lblGenre1;
        private System.Windows.Forms.Label lblAgeRating1;
        private System.Windows.Forms.Label lblTitle1;
    }
}