using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Traders
{
    public partial class custMain : Form
    {
        public custMain()
        {
            InitializeComponent();
        }

        /*private void button6_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
        }*/
        private void button6_Click(object sender, EventArgs e)
        {
            // Show a message box confirming logout
            MessageBox.Show("Logged out successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the current Main form
            this.Close();

            // Show the Welcome form (assumed to be the login form)
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchCarDetails scd = new searchCarDetails();
            scd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serachCarPartsDetails scpd = new serachCarPartsDetails();
            scpd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
