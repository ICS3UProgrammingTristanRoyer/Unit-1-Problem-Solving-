/*
 * Created by: Tristan Royer
 * Created on: 10 / 02 / 18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - PsuedoCode
 * This program calculates the cost of pizzas from the values input by the user.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostTristanR
{
	public partial class PizzaCostForm : Form
	{
		public PizzaCostForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnPrice_Click(object sender, EventArgs e)
		{
			// declare variables
			double diameter, total, subtotal, tax, amount;

			// assigns values to the variables
		     amount = (double)(nudAmount.Value);
			 diameter = (double)(nudDiameter.Value);
			
			// calculates the subtotal and displays it
			subtotal = (0.75 + 0.99 + 0.50 * diameter) * amount;
			this.lblSubtotal.Text = String.Format("${0:0.00}",subtotal);


			// calculates the tax and displays it
			tax = subtotal * 0.13;
			this.lblTax.Text = String.Format ("${0:0.00}", tax);

			// calculates the total and displays it
			total = subtotal + tax;
			this.lblTotal.Text = String.Format( "${0:0.00}", total);



		}

		private void PizzaCostForm_Load(object sender, EventArgs e)
		{

		}

		private void nudAmount_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
