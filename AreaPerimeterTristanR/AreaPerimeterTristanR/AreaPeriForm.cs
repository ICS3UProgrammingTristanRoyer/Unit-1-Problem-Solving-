/*
 * Created by: Tristan Royer
 * Created on: 18-09-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - AreaPerimeter
 * This program calculates area and perimeter bases on the length and width given by the user
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

namespace AreaPerimeterTristanR
{
    public partial class AreaPeriForm : Form
    {
        public AreaPeriForm()
        {
            InitializeComponent();

            // hide the perimeter and area labels
            this.lblAreaAnswer.Hide();
            this.lblPerimeterAnswer.Hide();
            this.lblArea.Hide();
            this.lblPerimeter.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double length, width, area, perimeter;
            

            // convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            // calculate the area and the perimeter
            area = length * width;
            perimeter = (2 * length) + (2 * width);

            // insert the area and the perimeter into their respective labels
            this.lblAreaAnswer.Text = Convert.ToString(area) + " squared meters";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " squared meters";

            // display the perimeter and area labels with their respective answers
            this.lblPerimeterAnswer.Show();
            this.lblAreaAnswer.Show();
            this.lblArea.Show();
            this.lblPerimeter.Show();

        }


        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
