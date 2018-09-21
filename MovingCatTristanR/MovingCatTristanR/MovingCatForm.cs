/*
 * Created by: Tristan Royer
 * Created on: 17-09-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - MovingCat
 * This program displays 2 different images of cats depending on which image you click to cause a walking motion
 * 
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

namespace MovingCatTristanR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //changes the property to the cat1 image.
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //changes the property to the cat2 image.
            this.picCat.Image = Properties.Resources.cat2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exits the program
            this.Close();
        }
    }
}
