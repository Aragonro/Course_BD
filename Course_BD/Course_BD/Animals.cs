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
    public partial class Animals : Form
    {
        const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\VS2015\DZ\Course_BD\Course_BD\ZOO.mdf; Integrated Security = True";
        public Animals()
        {
            InitializeComponent();
            
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open(); ;
                string zapros = "Select Id As 'Номер', Name AS 'Кличка', Weight As 'Вес', Age 'Возраст', Kind As 'Вид', Number_Cell As 'Номер клетки', Need_Square 'Требует площади' FROM Animals";
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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open(); ;
                string zapros = "Select Id As 'Номер', Name AS 'Кличка', Weight As 'Вес', Age 'Возраст', Kind As 'Вид', Number_Cell As 'Номер клетки', Need_Square 'Требует площади' FROM Animals";
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

        private void button_kinds_Click(object sender, EventArgs e)
        {
            Kinds form = new Kinds();
            form.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Animals_Add form = new Animals_Add();
            form.ShowDialog();
        }
    }
}
