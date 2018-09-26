namespace CircumfTristanR
{
	partial class frmCircumference
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
			this.txtRadius = new System.Windows.Forms.TextBox();
			this.lblDemand = new System.Windows.Forms.Label();
			this.lblCircumference = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtRadius
			// 
			this.txtRadius.Location = new System.Drawing.Point(184, 43);
			this.txtRadius.Name = "txtRadius";
			this.txtRadius.Size = new System.Drawing.Size(100, 20);
			this.txtRadius.TabIndex = 0;
			this.txtRadius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lblDemand
			// 
			this.lblDemand.AutoSize = true;
			this.lblDemand.Location = new System.Drawing.Point(2, 46);
			this.lblDemand.Name = "lblDemand";
			this.lblDemand.Size = new System.Drawing.Size(176, 13);
			this.lblDemand.TabIndex = 1;
			this.lblDemand.Text = "Enter the radius of the circle (in cm):";
			// 
			// lblCircumference
			// 
			this.lblCircumference.AutoSize = true;
			this.lblCircumference.Location = new System.Drawing.Point(12, 168);
			this.lblCircumference.Name = "lblCircumference";
			this.lblCircumference.Size = new System.Drawing.Size(110, 13);
			this.lblCircumference.TabIndex = 2;
			this.lblCircumference.Text = "The Circumference is:";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(184, 84);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 3;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Location = new System.Drawing.Point(139, 168);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblAnswer.TabIndex = 5;
			this.lblAnswer.Text = "--";
			// 
			// frmCircumference
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.lblCircumference);
			this.Controls.Add(this.lblDemand);
			this.Controls.Add(this.txtRadius);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmCircumference";
			this.Text = "Circumference";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtRadius;
		private System.Windows.Forms.Label lblDemand;
		private System.Windows.Forms.Label lblCircumference;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label lblAnswer;
	}
}

