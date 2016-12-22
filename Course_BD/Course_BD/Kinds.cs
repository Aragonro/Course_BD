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
    public partial class Kinds : Form
    {
        const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\VS2015\DZ\Course_BD\Course_BD\ZOO.mdf; Integrated Security = True";
        public Kinds()
        {
            InitializeComponent();
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open(); ;
                string zapros = "Select Kind FROM Kinds_Animals";
                SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                comboBox_kinds.Items.Clear();
                for(int i = 0; i < dt.Rows.Count; ++i)
                {
                    comboBox_kinds.Items.Add(dt.Rows[i]["Kind"]);
                }

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void Kinds_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_kinds_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string zapros = "Select Friend As'Виды возможных соседей' FROM Friends Where Kind=N'" + comboBox_kinds.Text + "';";
            SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            zapros = "Select Cell As'Возможное жильё' FROM Good_Cells Where Kind=N'" + comboBox_kinds.Text + "';";
            oda = new SqlDataAdapter(zapros, sqlconn);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView2.DataSource = dt;
            sqlconn.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "INSERT INTO Kinds_Animals VALUES(N'" + textBox_add.Text + "');";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                sqlconn.Close();
                comboBox_kinds.Items.Add(textBox_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_add_kind_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "INSERT INTO Friends(Kind,Friend) VALUES(N'" + comboBox_kinds.Text + "', N'" + textBox_add_kind.Text +"');";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                string zapros = "Select Friend As'Виды возможных соседей' FROM Friends Where Kind='" + comboBox_kinds.Text + "';";
                SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_add_cell_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "INSERT INTO Good_Cells(Kind,Cell) VALUES(N'" + comboBox_kinds.Text + "', N'" + textBox_add_cell.Text + "');";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                string zapros = "Select Cell As'Возможное жильё' FROM Good_Cells Where Kind='" + comboBox_kinds.Text + "';";
                SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_del_k_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "DELETE From Friends Where Friend=N'" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value +"' And Kind=N'" + comboBox_kinds.Text + "';";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                string zapros = "Select Friend As'Виды возможных соседей' FROM Friends Where Kind='" + comboBox_kinds.Text + "';";
                SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_del_c_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "DELETE From Good_Cells Where Cell=N'" + dataGridView2[0, dataGridView2.CurrentRow.Index].Value + "' And Kind=N'" + comboBox_kinds.Text + "';";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                string zapros = "Select Cell As'Возможное жильё' FROM Good_Cells Where Kind='" + comboBox_kinds.Text + "';";
                SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }
    }
}
