using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Traders
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("Pending");
            comboBox1.Items.Add("Delevered");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
