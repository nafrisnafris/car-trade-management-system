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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void loginRegister_Click(object sender, EventArgs e)
        {
           frmRegister ar = new frmRegister();
            ar.Show();
            this.Hide();
        }

        private void adminClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string uname = loginUsename.Text;
            string pass = loginPassword.Text;

            if (uname.Equals("admin") && pass.Equals("123"))
            {
                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main m = new Main();
                this.Hide();
                m.Show();
            }
            else
            {
                //MessageBox.Show("Username or password incorrect");
                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginUsename.Clear();
                loginPassword.Clear();
                loginUsename.Focus();
            }
        }

        private void loginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (loginShowPass.Checked)
                {
                    loginPassword.PasswordChar = '\0';
                }
                else
                {
                    loginPassword.PasswordChar = '*';
                }
            }
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
