using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Traders
{
    public partial class searchCarDetails : Form
    {
        public searchCarDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FSSI55O\\SQLEXPRESS;Initial Catalog=car_trader;User ID=sa;Password=12345;");
        /*SqlCommand cmd;
        SqlDataReader dr;
        string proid;
        string sql;
        bool Mode = true;
        string id;*/

        

        private void carDetailsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchCarDetails_Load(object sender, EventArgs e)
        {
            DataGv_CellContentClick(this, null);
        }

        private void DataGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            string query = "select * from carDetails";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DataGv.DataSource = ds.Tables[0];
            con.Close();
        }

       

        

        private void resetBtn_Click(object sender, EventArgs e)
        {
            DataGv_CellContentClick(this, null);
        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = txtSearch.Text.Trim();
            DataTable carDetails = (DataTable)DataGv.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                carDetails.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string rowFilter = $"Convert(CarRegNo, 'System.String') LIKE '%{filterText}%' " +
                                   $"OR Convert(brand, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(model, 'System.String') LIKE '%{filterText}%'" +
                                  
                                   $"OR Convert(Year, 'System.String') LIKE '%{filterText}%'";
                carDetails.DefaultView.RowFilter = rowFilter;
            }
        }
    }
}
