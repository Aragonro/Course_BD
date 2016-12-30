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

    public partial class Ward_Add : Form
    {
        const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\VS2015\DZ\Course_BD\Course_BD\ZOO.mdf; Integrated Security = True";

        public Ward_Add()
        {
            InitializeComponent();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string zapros = "Select Distinct Post From Wards ;";
            SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            textBox_post.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textBox_post.Items.Add(dt.Rows[i]["Post"]);
            }


            sqlconn.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "INSERT INTO Wards(Id, F_Name, S_Name, Birthday,Passport, Phone, Work_Start,Post) VALUES(" + textBox_id.Text + " ,N'"+ textBox_name.Text+"' ,N'"+textBox_sname.Text+"' ,'" + textBox_date.Text + "' ,N'" + textBox_pasport.Text + "' ,'"+textBox_phone.Text+"' ,'"+textBox_start_date.Text+"' ,N'"+textBox_post.Text+"');";
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

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
