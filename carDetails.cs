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
    public partial class carDetails : Form
    {
        public carDetails()
        {
            InitializeComponent();
           // Autono();
            load();
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
            sql = "Select carRegNo from carDetails order by carRegNo desc";
            cmd = new SqlCommand(sql,con);
            con.Open();
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid= id.ToString("00000");
            }
            else if(Convert.IsDBNull(dr)) 
            {
                proid = ("00000");
            }
            else 
            {
                proid = ("00000");
            }

            txtcarRegNo.Text = proid.ToString();
            con.Close();
        }*/

        public void load()
        {
            sql = "select * from carDetails";
            cmd = new SqlCommand(sql,con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while(dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }

            con.Close() ;
        }

        public void getid(string id)
        {
            sql = "select * from carDetails where carRegNo= '" + id + "' ";
            cmd = new SqlCommand(sql,con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtcarRegNo.Text = dr[0].ToString();
                txtBrand.Text = dr[1].ToString();
                txtModel.Text = dr[2].ToString();
                txtYear.Text = dr[3].ToString();
                txtPrice.Text = dr[4].ToString();
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarDetails_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carRegNo = txtcarRegNo.Text;
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string year = txtYear.Text;
            string price = txtPrice.Text;

            //id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (Mode == true)
            {
                sql = "insert into carDetails(carRegNo,brand,model,year,price) values(@carRegNo,@brand,@model,@year,@price)";
                con.Open();
                cmd = new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@carRegNo", carRegNo);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record added");
                MessageBox.Show("Record added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtBrand.Clear();
                txtModel.Clear();
                txtBrand.Clear();
                txtPrice.Clear();
                txtBrand.Focus();
               
            }
            else {
                sql = "update carDetails set brand=@brand, model=@model,year=@year,price=@price where carRegNo=@carRegNo";
                con.Open();
                cmd = new SqlCommand(sql, con);
                
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@price", price);
                //cmd.Parameters.AddWithValue("@availability", avl);
                cmd.Parameters.AddWithValue("@carRegNo", id);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record updated");
                MessageBox.Show("Record updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtcarRegNo.Enabled = true;
                Mode = true;

                txtBrand.Clear();
                txtModel.Clear();
                txtYear.Clear();
                txtPrice.Clear();
                //txtAvl.Items.Clear();
                //txtBrand.Focus();
                txtBrand.Clear();
                
            }

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >=0) 
            {
                Mode = false;
                txtcarRegNo.Enabled = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                getid(id);
            

            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "delete from carDetails where carRegNo=@id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record deleted");
                MessageBox.Show("Record deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close() ;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
            //Autono();
            txtBrand.Clear();
            txtModel.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            //txtAvl.Items.Clear();
            txtBrand.Focus();
        }
    }
}
