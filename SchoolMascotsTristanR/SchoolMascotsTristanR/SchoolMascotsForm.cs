/*
 * Created by: Tristan Royer
 * Created on: 23 / 09 / 18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - SchoolMascots
 * This program displays different schools and their mascots depending 
 * on the choice you pick
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

namespace SchoolMascotsTristanR
{
    public partial class SchoolMascotsForm : Form
    {
        public SchoolMascotsForm()
        {
            InitializeComponent();
        }

        private void mniSchool1_Click(object sender, EventArgs e)
        {
			//changes the text of the school label and the mascot label

			lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints";

        }

        private void mniSchool2_Click(object sender, EventArgs e)
        {
			//changes the text of the school label and the mascot label

			lblSchool.Text = "MotherTeresa";

			lblMascot.Text = "Spartans";

         
        }

        private void mniSchool3_Click(object sender, EventArgs e)
        {
			//changes the text of the school label and the mascot label
			lblSchool.Text = "St.Joe's";

			lblMascot.Text = "McJagger";

		}

        private void mniSchool4_Click(object sender, EventArgs e)
        {
			//changes the text of the school label and the mascot label

			lblSchool.Text = "St.Mark's";

			lblMascot.Text = "Spartan";

		}

		private void lblSchool_Click(object sender, EventArgs e)
		{

		}
	}
}
