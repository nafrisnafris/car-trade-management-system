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
    public partial class serachCarPartsDetails : Form
    {
        public serachCarPartsDetails()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FSSI55O\\SQLEXPRESS;Initial Catalog=car_trader;User ID=sa;Password=12345;");

        private void carPartsDetailsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serachCarPartsDetails_Load(object sender, EventArgs e)
        {
            dataCPD_CellContentClick(this,null);
        }

        private void dataCPD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            string query = "select * from carParts";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataCPD.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataCPD_CellContentClick(this, null);
        }

        private void txtPartsSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtPartsSearch.Text.Trim();
            DataTable carParts = (DataTable)dataCPD.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                carParts.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string rowFilter = $"Convert(partId, 'System.String') LIKE '%{filterText}%' " +
                                   $"OR Convert(partName, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(quantity, 'System.String') LIKE '%{filterText}%'" +
                                 
                                   $"OR Convert(warrenty, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(price, 'System.String') LIKE '%{filterText}%'";
                carParts.DefaultView.RowFilter = rowFilter;
            }
        }
    }
}
