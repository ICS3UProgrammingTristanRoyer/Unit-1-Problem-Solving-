namespace SchoolMascotsTristanR
{
    partial class SchoolMascotsForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.schoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSchool1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSchool2 = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSchool3 = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSchool4 = new System.Windows.Forms.ToolStripMenuItem();
			this.grbInformation = new System.Windows.Forms.GroupBox();
			this.lblMascot = new System.Windows.Forms.Label();
			this.lblSchool = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.grbInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// schoolsToolStripMenuItem
			// 
			this.schoolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchool1,
            this.mniSchool2,
            this.mniSchool3,
            this.mniSchool4});
			this.schoolsToolStripMenuItem.Name = "schoolsToolStripMenuItem";
			this.schoolsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.schoolsToolStripMenuItem.Text = "Schools";
			// 
			// mniSchool1
			// 
			this.mniSchool1.Name = "mniSchool1";
			this.mniSchool1.Size = new System.Drawing.Size(146, 22);
			this.mniSchool1.Text = "Immaculata";
			this.mniSchool1.Click += new System.EventHandler(this.mniSchool1_Click);
			// 
			// mniSchool2
			// 
			this.mniSchool2.Name = "mniSchool2";
			this.mniSchool2.Size = new System.Drawing.Size(146, 22);
			this.mniSchool2.Text = "MotherTeresa";
			this.mniSchool2.Click += new System.EventHandler(this.mniSchool2_Click);
			// 
			// mniSchool3
			// 
			this.mniSchool3.Name = "mniSchool3";
			this.mniSchool3.Size = new System.Drawing.Size(146, 22);
			this.mniSchool3.Text = "St.Joe\'s";
			this.mniSchool3.Click += new System.EventHandler(this.mniSchool3_Click);
			// 
			// mniSchool4
			// 
			this.mniSchool4.Name = "mniSchool4";
			this.mniSchool4.Size = new System.Drawing.Size(146, 22);
			this.mniSchool4.Text = "St.Mark\'s";
			this.mniSchool4.Click += new System.EventHandler(this.mniSchool4_Click);
			// 
			// grbInformation
			// 
			this.grbInformation.Controls.Add(this.lblMascot);
			this.grbInformation.Controls.Add(this.lblSchool);
			this.grbInformation.Location = new System.Drawing.Point(35, 72);
			this.grbInformation.Name = "grbInformation";
			this.grbInformation.Size = new System.Drawing.Size(200, 100);
			this.grbInformation.TabIndex = 1;
			this.grbInformation.TabStop = false;
			// 
			// lblMascot
			// 
			this.lblMascot.AutoSize = true;
			this.lblMascot.Location = new System.Drawing.Point(6, 69);
			this.lblMascot.Name = "lblMascot";
			this.lblMascot.Size = new System.Drawing.Size(13, 13);
			this.lblMascot.TabIndex = 1;
			this.lblMascot.Text = "--";
			// 
			// lblSchool
			// 
			this.lblSchool.AutoSize = true;
			this.lblSchool.Location = new System.Drawing.Point(6, 27);
			this.lblSchool.Name = "lblSchool";
			this.lblSchool.Size = new System.Drawing.Size(13, 13);
			this.lblSchool.TabIndex = 0;
			this.lblSchool.Text = "--";
			this.lblSchool.Click += new System.EventHandler(this.lblSchool_Click);
			// 
			// SchoolMascotsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.grbInformation);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SchoolMascotsForm";
			this.Text = "School Mascots";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.grbInformation.ResumeLayout(false);
			this.grbInformation.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniSchool1;
        private System.Windows.Forms.ToolStripMenuItem mniSchool2;
        private System.Windows.Forms.ToolStripMenuItem mniSchool3;
        private System.Windows.Forms.ToolStripMenuItem mniSchool4;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.Label lblSchool;
    }
}

