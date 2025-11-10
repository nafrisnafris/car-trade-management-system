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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           carDetails c =new carDetails();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerDetails customer = new customerDetails();
            customer.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carParts car = new carParts();
            car.Show();
        }

        /* private void button6_Click(object sender, EventArgs e)
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


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }
    }
}
