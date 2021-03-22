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

namespace Lab3AdamSkowronski
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-NBRHJEK;
                database=AdamSkowronskiLab3;
                Trusted_Connection=yes");
        }

        private void ButtonViewGrades_Click(object sender, EventArgs e)
        {
            ShowData("GradesView");
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
           
            SqlCommand command = new SqlCommand(@"INSERT INTO Courses(Name,Teacher) 
                                                VALUES (@Name, @Teacher",connection);
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxCourse.Text;
            command.Parameters.Add("@Teacher", SqlDbType.NVarChar).Value = textBoxName.Text;

            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ShowData(String table)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM {table} GradesView", connection);
            DataTable table1 = new DataTable();
            dataAdapter.Fill(table1);
            dataGridView1.DataSource = table1;
        }
    }
}
