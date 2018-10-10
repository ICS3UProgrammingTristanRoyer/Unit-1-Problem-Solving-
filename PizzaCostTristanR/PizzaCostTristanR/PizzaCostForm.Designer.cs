namespace PizzaCostTristanR
{
	partial class PizzaCostForm
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
			this.nudDiameter = new System.Windows.Forms.NumericUpDown();
			this.lblSub = new System.Windows.Forms.Label();
			this.lblTotalPrice = new System.Windows.Forms.Label();
			this.lblTaxes = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nudAmount = new System.Windows.Forms.NumericUpDown();
			this.btnPrice = new System.Windows.Forms.Button();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.lblTax = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// nudDiameter
			// 
			this.nudDiameter.Location = new System.Drawing.Point(137, 12);
			this.nudDiameter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudDiameter.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nudDiameter.Name = "nudDiameter";
			this.nudDiameter.Size = new System.Drawing.Size(120, 20);
			this.nudDiameter.TabIndex = 0;
			this.nudDiameter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// lblSub
			// 
			this.lblSub.AutoSize = true;
			this.lblSub.Location = new System.Drawing.Point(12, 147);
			this.lblSub.Name = "lblSub";
			this.lblSub.Size = new System.Drawing.Size(79, 13);
			this.lblSub.TabIndex = 1;
			this.lblSub.Text = "The subtotal is:";
			this.lblSub.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblTotalPrice
			// 
			this.lblTotalPrice.AutoSize = true;
			this.lblTotalPrice.Location = new System.Drawing.Point(12, 224);
			this.lblTotalPrice.Name = "lblTotalPrice";
			this.lblTotalPrice.Size = new System.Drawing.Size(62, 13);
			this.lblTotalPrice.TabIndex = 2;
			this.lblTotalPrice.Text = "The total is:";
			// 
			// lblTaxes
			// 
			this.lblTaxes.AutoSize = true;
			this.lblTaxes.Location = new System.Drawing.Point(12, 184);
			this.lblTaxes.Name = "lblTaxes";
			this.lblTaxes.Size = new System.Drawing.Size(56, 13);
			this.lblTaxes.TabIndex = 3;
			this.lblTaxes.Text = "The tax is:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter a diameter:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Enter the amount of pizzas:";
			// 
			// nudAmount
			// 
			this.nudAmount.Location = new System.Drawing.Point(152, 69);
			this.nudAmount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudAmount.Name = "nudAmount";
			this.nudAmount.Size = new System.Drawing.Size(120, 20);
			this.nudAmount.TabIndex = 6;
			this.nudAmount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
			// 
			// btnPrice
			// 
			this.btnPrice.Location = new System.Drawing.Point(21, 104);
			this.btnPrice.Name = "btnPrice";
			this.btnPrice.Size = new System.Drawing.Size(75, 23);
			this.btnPrice.TabIndex = 7;
			this.btnPrice.Text = "Price";
			this.btnPrice.UseVisualStyleBackColor = true;
			this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(201, 147);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(13, 13);
			this.lblSubtotal.TabIndex = 8;
			this.lblSubtotal.Text = "--";
			// 
			// lblTax
			// 
			this.lblTax.AutoSize = true;
			this.lblTax.Location = new System.Drawing.Point(201, 184);
			this.lblTax.Name = "lblTax";
			this.lblTax.Size = new System.Drawing.Size(13, 13);
			this.lblTax.TabIndex = 9;
			this.lblTax.Text = "--";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(201, 224);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(13, 13);
			this.lblTotal.TabIndex = 10;
			this.lblTotal.Text = "--";
			// 
			// PizzaCostForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblTax);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.btnPrice);
			this.Controls.Add(this.nudAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTaxes);
			this.Controls.Add(this.lblTotalPrice);
			this.Controls.Add(this.lblSub);
			this.Controls.Add(this.nudDiameter);
			this.Name = "PizzaCostForm";
			this.Text = "Pizza Cost";
			this.Load += new System.EventHandler(this.PizzaCostForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudDiameter;
		private System.Windows.Forms.Label lblSub;
		private System.Windows.Forms.Label lblTotalPrice;
		private System.Windows.Forms.Label lblTaxes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudAmount;
		private System.Windows.Forms.Button btnPrice;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.Label lblTax;
		private System.Windows.Forms.Label lblTotal;
	}
}

