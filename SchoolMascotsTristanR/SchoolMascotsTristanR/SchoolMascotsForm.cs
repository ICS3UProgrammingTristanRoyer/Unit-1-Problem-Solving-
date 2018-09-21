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
            lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints";

        }

        private void mniSchool2_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "MotherTeresa"
            lblMascot.Text = ""

         
        }

        private void mniSchool3_Click(object sender, EventArgs e)
        {

        }

        private void mniSchool4_Click(object sender, EventArgs e)
        {

        }
    }
}
