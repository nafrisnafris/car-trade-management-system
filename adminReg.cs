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
    public partial class frmAdminReg : Form
    {
        public frmAdminReg()
        {
            InitializeComponent();
        }

        private void adminReg_Load(object sender, EventArgs e)
        {

        }

        private void regLogin_Click(object sender, EventArgs e)
        {
            new frmAdminLogin().Show();
            this.Hide();
        }

        private void adminClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
