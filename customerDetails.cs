using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Traders
{
    public partial class customerDetails : Form
    {
        public customerDetails()
        {
            InitializeComponent();
           // Autono();
            customerload();

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FSSI55O\\SQLEXPRESS;Initial Catalog=car_trader;User ID=sa;Password=12345;");
        SqlCommand cmd;
        SqlDataReader dr;
        //string proid;
        string sql;
        bool Mode = true;
        string id;


        /*public void Autono()
        {
            sql = "Select customerId from customerDetails order by customerId desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("00001");
            }
            else
            {
                proid = ("00001");
            }

            txtCustomerID.Text = proid.ToString();
            con.Close();
        }*/


        public void customerload()
        {
            sql = "select * from customerDetails";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
            }

            con.Close();


        }

        public void getid(string id)
        {
            sql = "select * from customerDetails where customerID= '" + id + "' ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtCustomerID.Text = dr[0].ToString();
                txtCustomerName.Text = dr[1].ToString();
                txtNICNo.Text = dr[2].ToString();
                txtContactNumber.Text = dr[3].ToString();
                txtAddress.Text = dr[4].ToString();
                txtUsername.Text = dr[5].ToString();
                txtPassword.Text = dr[6].ToString();
            }
            con.Close();
        }






        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerID = txtCustomerID.Text;
            string customerName = txtCustomerName.Text;
            string nicNo = txtNICNo.Text;
            string contactNumber = txtContactNumber.Text;
            string address = txtAddress.Text;
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            //id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (Mode == true)
            {
                sql = "insert into customerDetails(customerID,customerName,nicNo,contactNumber,address,userName,password) values(@customerID,@customerName,@nicNo,@contactNumber,@address,@userName,@password)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@customerID", customerID);
                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.Parameters.AddWithValue("@nicNo", nicNo);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue ("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record added");
                MessageBox.Show("Record added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtCustomerName.Clear();
                txtNICNo.Clear();
                txtContactNumber.Clear();
                txtAddress.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtCustomerName.Focus();

            }
            else
            {
                sql = "update customerDetails set customerName=@customerName, nicNo=@nicNo,contactNumber=@contactNumber,address=@address,userName=@userName,password=@password where customerID=@customerID";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.Parameters.AddWithValue("@nicNo", nicNo);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@customerID", id);


                cmd.ExecuteNonQuery();
                // MessageBox.Show("Record updated");
                MessageBox.Show("Record updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCustomerID.Enabled = true;
                Mode = true;

                txtCustomerName.Clear();
                txtNICNo.Clear();
                txtContactNumber.Clear();
                txtAddress.Clear();
                txtCustomerName.Focus();

            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
                {
                    Mode = false;
                    txtCustomerID.Enabled = false;
                    id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    getid(id);


                }
                else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
                {
                    Mode = false;
                    id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    sql = "delete from customerDetails where customerID=@id";
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Record deleted");
                    MessageBox.Show("Record deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerload();
            //Autono();
            txtCustomerName.Clear();
            txtNICNo.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtCustomerName.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
