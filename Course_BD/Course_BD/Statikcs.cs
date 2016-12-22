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
    public partial class Statikcs : Form
    {
        const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\VS2015\DZ\Course_BD\Course_BD\ZOO.mdf; Integrated Security = True";

        public Statikcs()
        {
            InitializeComponent();
            
        }

        private void Statikcs_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string zapros = "Select Kind , Count(Id)  From Cells Group By Kind ";
            SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
            DataSet dt = new DataSet();
            oda.Fill(dt);
            chart1.DataSource = dt;
            chart1.Series["Series1"].XValueMember = (dt.Tables[0].Columns[0]).ToString();
            chart1.Series["Series1"].YValueMembers = (dt.Tables[0].Columns[1]).ToString();

            chart1.DataBind();
            zapros = "Select Kinds_Animals.Kind , Count(Id) From Kinds_Animals, Animals Where Animals.Kind=Kinds_Animals.Kind Group By Kinds_Animals.Kind ";
            oda = new SqlDataAdapter(zapros, sqlconn);
            dt = new DataSet();
            oda.Fill(dt);
            chart2.DataSource = dt;
            chart2.Series["Series1"].XValueMember = (dt.Tables[0].Columns[0]).ToString();
            chart2.Series["Series1"].YValueMembers = (dt.Tables[0].Columns[1]).ToString();
            zapros = "Select Post, Count(Id) From Wards Group By Post";
            oda = new SqlDataAdapter(zapros, sqlconn);
            dt = new DataSet();
            oda.Fill(dt);
            chart3.DataSource = dt;
            chart3.Series["Series1"].XValueMember = (dt.Tables[0].Columns[0]).ToString();
            chart3.Series["Series1"].YValueMembers = (dt.Tables[0].Columns[1]).ToString();

        }
    }
}
