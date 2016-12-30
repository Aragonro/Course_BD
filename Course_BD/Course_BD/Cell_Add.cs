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

namespace Course_BD
{
    public partial class Cell_Add : Form
    {
        const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\VS2015\DZ\Course_BD\Course_BD\ZOO.mdf; Integrated Security = True";
        public Cell_Add()
        {
            InitializeComponent();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string zapros = "Select Distinct Kind From Cells ;";
            SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            textBox_Kind.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textBox_Kind.Items.Add(dt.Rows[i]["Kind"]);
            }
            zapros = "Select Distinct Cell From Good_Cells Where Cell Not In (Select Kind From Cells);";
            oda = new SqlDataAdapter(zapros, sqlconn);
            dt = new DataTable();
            oda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textBox_Kind.Items.Add(dt.Rows[i]["Cell"]);
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "INSERT INTO Cells(Id, Square, Kind) VALUES(" + textBox_name.Text + " ," + textBox_S.Text + " ,N'" + textBox_Kind.Text + "');";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                sqlconn.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
