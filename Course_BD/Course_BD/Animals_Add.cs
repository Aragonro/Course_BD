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
    public partial class Animals_Add : Form
    {
        const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\VS2015\DZ\Course_BD\Course_BD\ZOO.mdf; Integrated Security = True";

        public Animals_Add()
        {
            InitializeComponent();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string zapros = "Select Kind FROM Kinds_Animals";
            SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                comboBox_kind.Items.Add(dt.Rows[i]["Kind"]);
            }
            sqlconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_cell.Text != "Автоматически")
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    string sql = "INSERT INTO Animals VALUES(" + textBox_id.Text + " ,N'" + textBox_name.Text + "' ," + textBox_square.Text + " ,'" + textBox_weight.Text + "' ," + textBox_age.Text + " ,N'" + comboBox_kind.Text + "' ," + comboBox_cell.Text + ");";
                    if (sqlconn.State != ConnectionState.Open)
                        sqlconn.Open();
                    SqlCommand command = new SqlCommand(sql, sqlconn);
                    int x = command.ExecuteNonQuery();
                    sqlconn.Close();
                    Close();
                }
                else
                {
                    if (comboBox_cell.Items.Count == 1)
                    {
                        MessageBox.Show("Нет подходящей клетки");
            
                    }
                    else
                    {
                        SqlConnection sqlconn = new SqlConnection(ConnectionString);
                        sqlconn.Open();
                        int i1 = -1;
                        int s1=0;
                        int i2 = -1;
                        int s2=0;
                        int i3 = -1;
                        for(int i = 1; i < comboBox_cell.Items.Count; ++i)
                        {
                            
                            string zapros = "Select F=(Select Square From Cells Where Id="+
                                comboBox_cell.Items[i]+"), S=Coalesce(Sum(Need_Square),0), G=(Select Count(Id)"+" From Animals Where Number_Cell="
                                + comboBox_cell.Items[i] + ")-(Select Count(Id) From Animals Where Number_Cell="
                                + comboBox_cell.Items[i]+" And Kind=N'"+
                                comboBox_kind.Text+"')  FROM Animals Where Number_Cell="+comboBox_cell.Items[i]+";";

                            SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                            DataTable dt = new DataTable();
                            oda.Fill(dt);
                            int f = Convert.ToInt32(dt.Rows[0]["F"]);
                            int s = Convert.ToInt32(dt.Rows[0]["S"]);
                            int g = Convert.ToInt32(dt.Rows[0]["G"]);
                            int cur= Convert.ToInt32(comboBox_cell.Items[i]);
                            if (s == 0)
                            {
                                if (i3 == -1)
                                {
                                    i3 = cur;
                                }
                            }
                            else if (g == 0)
                            {
                                if (i1 == -1)
                                {
                                    i1 = cur;
                                    s1 = f - s;
                                }
                                else if (s1 > f - s)
                                {
                                    s1 = f - s;
                                    i1 = cur;
                                }
                            }
                            else
                            {
                                if (i2 == -1)
                                {
                                    i2 = cur;
                                    s2 = f - s;
                                }
                                else
                                {
                                    if (s2 > f - s)
                                    {
                                        s2 = f - s;
                                    }
                                }
                            }

                        }
                        int cur1 = -1;
                        if (i1 != -1)
                        {
                            cur1= i1;
                        }
                        else if (i2 != -1)
                        {
                            cur1 = i2;
                        }
                        else if (i3 != -1)
                        {
                            cur1 = i3;
                        }
                        string sql = "INSERT INTO Animals VALUES(" + textBox_id.Text + " ,N'" + textBox_name.Text + "' ," + textBox_square.Text + " ,'" + textBox_weight.Text + "' ," + textBox_age.Text + " ,N'" + comboBox_kind.Text + "' ," + cur1 + ");";
                        if (sqlconn.State != ConnectionState.Open)
                            sqlconn.Open();
                        SqlCommand command = new SqlCommand(sql, sqlconn);
                        int x = command.ExecuteNonQuery();
                        sqlconn.Close();
                        Close();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void comboBox_kind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string zapros = "Select Id FROM Cells Where Cells.Kind In (Select Good_Cells.Cell From Good_Cells Where Kind=N'" + comboBox_kind.Text + "') And ((Select Count(Animals.Id) From Animals Where Animals.Number_Cell=Cells.Id)=0 Or Square>=((Select Sum(Need_Square) From Animals Where Animals.Number_Cell=Cells.Id)+" + textBox_square.Text + ")) And (Select Count(Animals.Id) From Animals Where Number_Cell= Cells.Id And Animals.Kind Not In(Select Friend From Friends Where Friends.Kind=N'" + comboBox_kind.Text + "'))=0 ;";
                SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                comboBox_cell.Items.Clear();
                comboBox_cell.Items.Add("Автоматически");
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    comboBox_cell.Items.Add(dt.Rows[i]["Id"]);
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                if (textBox_square.Text!="")
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void textBox_square_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_kind.Text != "")
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    string zapros = "Select Id FROM Cells Where Cells.Kind In (Select Good_Cells.Cell From Good_Cells Where Kind=N'" + comboBox_kind.Text + "') And ((Select Count(Animals.Id) From Animals Where Animals.Number_Cell=Cells.Id)=0 Or Square>=((Select Sum(Need_Square) From Animals Where Animals.Number_Cell=Cells.Id)+" + textBox_square.Text + ")) And (Select Count(Animals.Id) From Animals Where Number_Cell= Cells.Id And Animals.Kind Not In(Select Friend From Friends Where Friends.Kind=N'" + comboBox_kind.Text + "'))=0 ;";
                    SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    comboBox_cell.Items.Clear();
                    comboBox_cell.Items.Add("Автоматически");
                    for (int i = 0; i < dt.Rows.Count; ++i)
                    {
                        comboBox_cell.Items.Add(dt.Rows[i]["Id"]);
                    }
                    sqlconn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
