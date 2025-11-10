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
    public partial class carParts : Form
    {
        public carParts()
        {
            InitializeComponent();
            //Autono();
            partsload();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FSSI55O\\SQLEXPRESS;Initial Catalog=car_trader;User ID=sa;Password=12345;");
        SqlCommand cmd;
        SqlDataReader dr;
       // string proid;
        string sql;
        bool Mode = true;
        string id;


        /*public void Autono()
        {
            sql = "Select partId from carParts order by partId desc";
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
                proid = ("00000");
            }
            else
            {
                proid = ("00000");
            }

            txtPartId.Text = proid.ToString();
            con.Close();
        }*/


        public void partsload()
        {
            sql = "select * from carParts";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }

            con.Close();
        }



        public void getid(string id)
        {
            sql = "select * from carParts where partId= '" + id + "' ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtPartId.Text = dr[0].ToString();
                txtPartName.Text = dr[1].ToString();
                //txtPartCatag.Text = dr[2].ToString();
                txtQuantity.Text = dr[2].ToString();
                txtWarranty.Text = dr[3].ToString();
                txtPrice.Text = dr[4].ToString();
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partId = txtPartId.Text;
            string partName = txtPartName.Text;
            //string partCateg = txtPartCatag.SelectedItem.ToString();
            string quantity = txtQuantity.Text;
            string warrenty = txtWarranty.Text;
            string price = txtPrice.Text;

            //id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (Mode == true)
            {
                sql = "insert into carParts(partId,partName,quantity,warrenty,price) values(@partId,@partName,@quantity,@warrenty,@price)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@partId", partId);
                cmd.Parameters.AddWithValue("@partName", partName);
                //cmd.Parameters.AddWithValue("@partCateg", partCateg);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@warrenty", warrenty);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record added");
                MessageBox.Show("Record added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPartName.Clear();
                //txtPartCatag.Items.Clear();
                txtQuantity.Clear();
                txtWarranty.Clear();
                txtPrice.Clear();
                txtPartName.Focus();

            }
            else
            {
                sql = "update carParts set partName=@partName,quantity=@quantity,warrenty=@warrenty,price=@price where partId=@partId";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@partName", partName);
                //cmd.Parameters.AddWithValue("@partCateg", partCateg);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@warrenty", warrenty);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@partId", id);


                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record updated");
                MessageBox.Show("Record updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPartId.Enabled = true;
                Mode = true;

                txtPartName.Clear();
                //txtPartCatag.Items.Clear();
                txtQuantity.Clear();
                txtWarranty.Clear();
                txtPrice.Clear();
                txtPartName.Focus();

            }

            con.Close();
        }

        private void txtPartId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                txtPartId.Enabled = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                getid(id);


            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "delete from carParts where partId=@id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record deleted");
                MessageBox.Show("Record deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            partsload();
            //Autono();
            txtPartName.Clear();
            //txtPartCatag.Items.Clear();
            txtQuantity.Clear();
            txtWarranty.Clear();
            txtPrice.Clear();
            txtPartName.Focus();
        }

        private void carParts_Load(object sender, EventArgs e)
        {

        }
    }
}
