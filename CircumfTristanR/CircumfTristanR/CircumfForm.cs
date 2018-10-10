/*
 * Created by: Tristan Royer
 * Created on: 9th October 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Circumference 
 * This program displays a circumference based on the radius value input by the user
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

namespace CircumfTristanR
{
	public partial class frmCircumference : Form
	{
		public frmCircumference()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			//declare local variables
			double radius, circumference;

			// convert the string from the text box to a double
			radius = double.Parse(txtRadius.Text);

			//Calculate the Circumference
			circumference = 2 * Math.PI * radius;

			//Insert the Circumference
			this.lblAnswer.Text = Convert.ToString(circumference) + " squared meters";
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// closes the program
			this.Close();
		}
	}
}
