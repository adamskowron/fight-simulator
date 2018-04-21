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

namespace AdamSkowronskiLab3
{
    public partial class mainWindow : Form
    {
        SqlConnection connection;
        public mainWindow()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = DESKTOP-NBRHJEK;database = Pizzeria; Trusted_Connection=yes");

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM pizzas",connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM pizzas WHERE Price > 0{textBoxFilter.Text}", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
        }
    }
}
