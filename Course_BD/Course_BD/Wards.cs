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
    public partial class Wards : Form
    {
        int cur_row = -1;
        int cur_index = -1;
        int fatal = 0;
        const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\VS2015\DZ\Course_BD\Course_BD\ZOO.mdf; Integrated Security = True";
        public void refresh()
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string zapros = "SELECT Id AS 'Номер Сотрудника', F_Name AS 'Имя Сотрудника', S_Name AS 'Фамилия Сотрудника', Post As 'Должность', Passport AS 'Паспорт', Phone As 'Телефон', Birthday As 'День рождения', Work_Start As 'Дата начала работы', Work_Finish As 'Дата увольнения','Количество клеток'=(Select Count(cells_wards.Id) From cells_wards Where Wards.Id=cells_wards.Id_ward) From Wards Group By Id, F_Name, S_Name, Post, Passport, Phone, Birthday, Work_Start, Work_Finish ";
                SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                DataTable dt = new DataTable();
                
                oda.Fill(dt);
                dataGridView1.DataSource = dt;

                zapros = "Select Id_cell AS 'Номер клетки', 'Количество животных в клетке' = (Select Count(Animals.Id) From Animals Where Number_Cell=Id_cell), Duties As 'Обязоности' From cells_wards Where Id_ward=" + cur_index + " Group By Id_cell, Duties";
                oda = new SqlDataAdapter(zapros, sqlconn);
                dt = new DataTable();

                oda.Fill(dt);
                dataGridView2.DataSource = dt;
                zapros = "Select Id From Cells Where Id Not In (Select Id_cell From cells_wards Where Id_ward=" + cur_index + ");";
                oda = new SqlDataAdapter(zapros, sqlconn);
                dt = new DataTable();

                oda.Fill(dt);
                comboBox_cells.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox_cells.Items.Add(dt.Rows[i]["Id"]);
                }

                sqlconn.Close();

            }
            catch (Exception ex)
            {
                if (fatal == 0)
                {
                    fatal = 1;
                    MessageBox.Show(@"Error: " + ex.Message);
                }
                else
                {
                    fatal = 0;
                }
            }
        }
        public void refresh_2()
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string zapros;
                SqlDataAdapter oda;
                DataTable dt = new DataTable();
                if (cur_row != dataGridView1.CurrentRow.Index && dataGridView1.CurrentRow.Index != dataGridView1.Rows.Count - 1)
                {
                    cur_row = dataGridView1.CurrentRow.Index;
                    cur_index = Convert.ToInt32(dataGridView1[0, cur_row].Value);
                    textBox_id.Text = Convert.ToString(dataGridView1[0, cur_row].Value);
                    textBox_fname.Text = Convert.ToString(dataGridView1[1, cur_row].Value);
                    textBox_sname.Text = Convert.ToString(dataGridView1[2, cur_row].Value);
                    textBox_post.Text = Convert.ToString(dataGridView1[3, cur_row].Value);
                    textBox_passport.Text = Convert.ToString(dataGridView1[4, cur_row].Value);
                    textBox_phone.Text = Convert.ToString(dataGridView1[5, cur_row].Value);
                    textBox_date.Text = Convert.ToString(dataGridView1[6, cur_row].Value);
                    textBox_works.Text = Convert.ToString(dataGridView1[7, cur_row].Value);
                    textBox_workf.Text = Convert.ToString(dataGridView1[8, cur_row].Value);

                    sqlconn.Open();
                     zapros = "Select Id_cell AS 'Номер клетки', 'Количество животных в клетке' = (Select Count(Animals.Id) From Animals Where Number_Cell=Id_cell), Duties As 'Обязоности' From cells_wards Where Id_ward=" + cur_index + " Group By Id_cell, Duties";
                    oda = new SqlDataAdapter(zapros, sqlconn);
                    dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView2.DataSource = dt;
                    zapros = "Select Id From Cells Where Id Not In (Select Id_cell From cells_wards Where Id_ward=" + cur_index + ");";
                    oda = new SqlDataAdapter(zapros, sqlconn);
                    dt = new DataTable();

                    oda.Fill(dt);
                    comboBox_cells.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        comboBox_cells.Items.Add(dt.Rows[i]["Id"]);
                    }
                    

                    sqlconn.Close();
                }
                sqlconn.Open();
                
                zapros = "Select Distinct Post From Wards ;";
                oda = new SqlDataAdapter(zapros, sqlconn);
                dt = new DataTable();

                oda.Fill(dt);
                textBox_post.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    textBox_post.Items.Add(dt.Rows[i]["Post"]);
                }


                sqlconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }
        public Wards()
        {
            InitializeComponent();
            refresh();
        }
        

        private void Wards_Load(object sender, EventArgs e)
        {

        }

        private void Wards_Activated(object sender, EventArgs e)
        {
            try
            {
                refresh();
            }
            catch (Exception ex)
            {
                
                    MessageBox.Show(@"Error: " + ex.Message);
                
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Ward_Add form = new Ward_Add();
            form.ShowDialog();
        }

        private void Wards_MouseUp(object sender, MouseEventArgs e)
        {
            
                
            
            
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            refresh_2();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "Update Wards SET Id=" + textBox_id.Text + " ,F_Name=N'" + textBox_fname.Text + "' ,S_Name =N'" + textBox_sname.Text + "', Post = N'" + textBox_post.Text + "', Passport= N'" + textBox_passport.Text + "', Phone = '" + textBox_phone.Text + "', Birthday='" + textBox_date.Text + "' ,Work_Start='" + textBox_works.Text + "' , Work_Finish='" + textBox_workf.Text + "'  WHERE Id=" + cur_index + ";";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                sqlconn.Close();
                refresh();
                cur_index = Convert.ToInt32(textBox_id.Text);
                refresh_2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "DELETE From cells_wards Where Id_ward=" + cur_index + ";";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                sql = "Update Wards Set Work_Finish='" + DateTime.Now.ToShortDateString() + "' Where Id=" + cur_index + ";";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                command = new SqlCommand(sql, sqlconn);
                x = command.ExecuteNonQuery();
                sqlconn.Close();
                refresh();
                cur_row = 0;
                cur_index = Convert.ToInt32(dataGridView1[0, 0].Value);
                refresh_2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                int cur_cell = Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentRow.Index].Value);
                string sql = "DELETE From cells_wards Where Id_ward=" + cur_index + " And Id_cell="+cur_cell+";";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                sqlconn.Close();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_cell_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                int cur_cell = Convert.ToInt32(comboBox_cells.Text);
                string sql = "INSERT INTO cells_wards( Id_cell, Id_ward, Duties) VALUES(" + cur_cell + " ," + cur_index + " ,N'" + textBox_duties.Text + "');";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                sqlconn.Close();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_change_duties_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                int cur_cell = Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentRow.Index].Value);
                string sql = "Update cells_wards Set Duties=N'" + textBox_change_duties.Text + "'  Where Id_ward=" + cur_index + " And Id_cell=" + cur_cell + ";";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                sqlconn.Close();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void dataGridView2_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
