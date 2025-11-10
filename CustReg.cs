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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IOGAT6U\\SQLEXPRESS;Initial Catalog=CarTraders;User ID=sa;Password=admin123;");
        SqlCommand cmd;
        /*SqlDataReader dr;
        string proid;
        string sql;
        bool Mode = true;
        string id;*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                if (regCustomername.Text == "" || regNic.Text =="" || regContact.Text =="" || regAddress.Text == "" || regUsername.Text == ""
                    || regPassword.Text == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();
                            String checkUsername = "SELECT * FROM customerDetails WHERE userName = '"
                                + regUsername.Text.Trim() + "'"; 

                            using (SqlCommand checkUser = new SqlCommand(checkUsername, con))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count >= 1)
                                {
                                    MessageBox.Show(regUsername.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string insertData = "INSERT INTO customerDetails (customerName,nicNo,contactNumber,address, userName, password) " +
                                        "VALUES(@customerName,@nicNo,@contactNumber,@address, @userName, @password)";
                                   

                                    using (SqlCommand cmd = new SqlCommand(insertData, con))
                                    {
                                        cmd.Parameters.AddWithValue("@customerName", regCustomername.Text.Trim());
                                        cmd.Parameters.AddWithValue("@nicNo", regNic.Text.Trim());
                                        cmd.Parameters.AddWithValue("@contactNumber", regContact.Text.Trim());
                                        cmd.Parameters.AddWithValue("@address", regAddress.Text.Trim());
                                        cmd.Parameters.AddWithValue("@userName", regUsername.Text.Trim());
                                        cmd.Parameters.AddWithValue("@password", regPassword.Text.Trim());
                                        

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // TO SWITCH THE FORM 
                                        frmLogin l = new frmLogin();
                                        l.Show();
                                        this.Hide();
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }

                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {

            {
                if (regShowPass.Checked)
                {
                    regPassword.PasswordChar = '\0';
                }
                else
                {
                    regPassword.PasswordChar = '*';
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void regClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void regUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void regPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void regiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
