using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Traders
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FSSI55O\\SQLEXPRESS;Initial Catalog=car_trader;User ID=sa;Password=12345;");
        /*SqlCommand cmd;
        SqlDataReader dr;*/

        private void custLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtConfPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            f.Show();
            this.Hide();



        }

        private void txtUsename_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*con.Open();
            string login = "SELECT * FROM customerReg WHERE '" + loginUsename.Text + "' and password= '" + loginPassword.Text + "'";
            cmd = new SqlCommand(login,con);
            dr = cmd.ExecuteReader();*/
            {
                if (loginUsename.Text == "" || loginPassword.Text == "")
                {
                    MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();

                            String selectData = "SELECT * FROM customerDetails WHERE userName = @userName AND password = @password";
                            using (SqlCommand cmd = new SqlCommand(selectData, con))
                            {
                                cmd.Parameters.AddWithValue("@userName", loginUsename.Text);
                                cmd.Parameters.AddWithValue("@password", loginPassword.Text);
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count >= 1)
                                {
                                    MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    custMain cm = new custMain();
                                    cm.Show();
                                    this.Hide();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void loginClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
