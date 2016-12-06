namespace WindowsFormsApplication1
{
    partial class frmDVDReg
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
            this.mnuDVDReg = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.cboAgeRating = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.cboRetalRate = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDVDidno = new System.Windows.Forms.Label();
            this.lblDVDid = new System.Windows.Forms.Label();
            this.mnuDVDReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDVDReg
            // 
            this.mnuDVDReg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuDVDReg.Location = new System.Drawing.Point(0, 0);
            this.mnuDVDReg.Name = "mnuDVDReg";
            this.mnuDVDReg.Size = new System.Drawing.Size(316, 24);
            this.mnuDVDReg.TabIndex = 0;
            this.mnuDVDReg.Text = "menuStrip1";
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(12, 88);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(60, 13);
            this.lblAgeRating.TabIndex = 3;
            this.lblAgeRating.Text = "Age Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(11, 115);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(11, 142);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(64, 13);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "Rental Rate";
            // 
            // cboAgeRating
            // 
            this.cboAgeRating.FormattingEnabled = true;
            this.cboAgeRating.Location = new System.Drawing.Point(78, 85);
            this.cboAgeRating.Name = "cboAgeRating";
            this.cboAgeRating.Size = new System.Drawing.Size(149, 21);
            this.cboAgeRating.TabIndex = 4;
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(78, 112);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(149, 21);
            this.cboGenre.TabIndex = 6;
            // 
            // cboRetalRate
            // 
            this.cboRetalRate.FormattingEnabled = true;
            this.cboRetalRate.Location = new System.Drawing.Point(78, 139);
            this.cboRetalRate.Name = "cboRetalRate";
            this.cboRetalRate.Size = new System.Drawing.Size(149, 21);
            this.cboRetalRate.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(78, 59);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(149, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(78, 203);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDVDidno
            // 
            this.lblDVDidno.AutoSize = true;
            this.lblDVDidno.Location = new System.Drawing.Point(78, 28);
            this.lblDVDidno.Name = "lblDVDidno";
            this.lblDVDidno.Size = new System.Drawing.Size(13, 13);
            this.lblDVDidno.TabIndex = 11;
            this.lblDVDidno.Text = "1";
            // 
            // lblDVDid
            // 
            this.lblDVDid.AutoSize = true;
            this.lblDVDid.Location = new System.Drawing.Point(13, 27);
            this.lblDVDid.Name = "lblDVDid";
            this.lblDVDid.Size = new System.Drawing.Size(38, 13);
            this.lblDVDid.TabIndex = 12;
            this.lblDVDid.Text = "DVDid";
            // 
            // frmDVDReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 255);
            this.Controls.Add(this.lblDVDid);
            this.Controls.Add(this.lblDVDidno);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cboRetalRate);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.cboAgeRating);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgeRating);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuDVDReg);
            this.MainMenuStrip = this.mnuDVDReg;
            this.Name = "frmDVDReg";
            this.Text = "Register DVD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDVDReg_FormClosed);
            this.Load += new System.EventHandler(this.frmDVDReg_Load);
            this.mnuDVDReg.ResumeLayout(false);
            this.mnuDVDReg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDVDReg;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.ComboBox cboAgeRating;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.ComboBox cboRetalRate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDVDidno;
        private System.Windows.Forms.Label lblDVDid;
    }
}