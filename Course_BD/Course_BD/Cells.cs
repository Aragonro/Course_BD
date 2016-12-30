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
    public partial class Cells : Form
    {
        int cur_row=-1;
        int cur_index = -1;
        int fatal = 0;
        int prov = 0;
        const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\VS2015\DZ\Course_BD\Course_BD\ZOO.mdf; Integrated Security = True";
        public void refresh()
        {
            if (prov == 0)
            {
                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    string zapros = "SELECT Cells.Id AS 'Номер клетки', Cells.Square AS 'Площадь клетки', Cells.Kind AS 'Вид клетки', 'Количество животных в клетке'=(SELECT Count(Animals.Id) FROM Animals WHERE Animals.Number_Cell=Cells.Id) FROM Cells GROUP BY Cells.Id, Cells.Square, Cells.Kind;";
                    SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                    DataTable dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    zapros = "Select Id_ward As 'Номер', F_Name As 'Имя', S_Name As 'Фамилия', Duties As 'Обязаности' From cells_wards, Wards Where Id_ward=Wards.Id And Id_cell=" + cur_index + ";";
                    oda = new SqlDataAdapter(zapros, sqlconn);
                    dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView2.DataSource = dt;
                    zapros = "Select Animals.Id As 'Номер Животного', Animals.Name As 'Имя животного', Animals.Age As 'Возраст', Animals.Kind As 'Вид', Need_Square As 'Занимает места' From Animals Where Number_Cell=" + cur_index + ";";
                    oda = new SqlDataAdapter(zapros, sqlconn);
                    dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView3.DataSource = dt;
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
        }
        public Cells()
        {
            InitializeComponent();
            try
            {
                refresh();
                if (dataGridView1.Rows.Count > 1)
                {
                    cur_row = 0;
                    cur_index = Convert.ToInt32(dataGridView1[0, 0].Value);
                    textBox_name.Text = Convert.ToString(dataGridView1[0, cur_row].Value);
                    textBox_S.Text = Convert.ToString(dataGridView1[1, cur_row].Value);
                    textBox_Kind.Text = Convert.ToString(dataGridView1[2, cur_row].Value);
                }
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
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }

        private void button_refresh_Click(object sender, EventArgs e)
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

        private void Cells_Load(object sender, EventArgs e)
        {

        }

        private void Cells_MouseUp(object sender, MouseEventArgs e)
        {
            if (cur_row != dataGridView1.CurrentRow.Index)
            {
                cur_row = dataGridView1.CurrentRow.Index;
                cur_index = Convert.ToInt32(dataGridView1[0, cur_row].Value);
                textBox_name.Text = Convert.ToString(dataGridView1[0, cur_row].Value);
                textBox_S.Text = Convert.ToString(dataGridView1[1, cur_row].Value);
                textBox_Kind.Text = Convert.ToString(dataGridView1[2, cur_row].Value);
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "Update Cells SET Id=" + textBox_name.Text + " ,Square=" + textBox_S.Text + " ,Kind =N'" + textBox_Kind.Text + "' WHERE Id=" + cur_index+";";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                sqlconn.Close();
                refresh();
                cur_index = Convert.ToInt32(textBox_name.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (cur_row != dataGridView1.CurrentRow.Index && dataGridView1.CurrentRow.Index != dataGridView1.Rows.Count - 1)
                {
                    cur_row = dataGridView1.CurrentRow.Index;
                    cur_index = Convert.ToInt32(dataGridView1[0, cur_row].Value);
                    textBox_name.Text = Convert.ToString(dataGridView1[0, cur_row].Value);
                    textBox_S.Text = Convert.ToString(dataGridView1[1, cur_row].Value);
                    textBox_Kind.Text = Convert.ToString(dataGridView1[2, cur_row].Value);
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    string zapros = "Select Id_ward As 'Номер', F_Name As 'Имя', S_Name As 'Фамилия', Duties As 'Обязаности' From cells_wards, Wards Where Id_ward=Wards.Id And Id_cell=" + cur_index + ";";
                    SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                    DataTable dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView2.DataSource = dt;
                    zapros = "Select Animals.Id As 'Номер Животного', Animals.Name As 'Имя животного', Animals.Age As 'Возраст', Animals.Kind As 'Вид', Need_Square As 'Требует места' From Animals Where Number_Cell=" + cur_index + ";";
                    oda = new SqlDataAdapter(zapros, sqlconn);
                    dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Cell_Add form = new Cell_Add();
            form.ShowDialog();
        }

        private void Cells_Activated(object sender, EventArgs e)
        {
            refresh();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                string sql = "Delete From cells_wards Where Id_cell=" + cur_index + ";";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                SqlCommand command = new SqlCommand(sql, sqlconn);
                int x = command.ExecuteNonQuery();
                sql = "DELETE From Cells Where Id=" + cur_index + ";";
                if (sqlconn.State != ConnectionState.Open)
                    sqlconn.Open();
                command = new SqlCommand(sql, sqlconn);
                x = command.ExecuteNonQuery();
                sqlconn.Close();
                refresh();
                cur_row = 0;
                cur_index = Convert.ToInt32(dataGridView1[0, 0].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox_search.Text=="Номер клетки")
                {
                    prov = 1;
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    string zapros = "SELECT Cells.Id AS 'Номер клетки', Cells.Square AS 'Площадь клетки', Cells.Kind AS 'Вид клетки', 'Количество животных в клетке'=(SELECT Count(Animals.Id) FROM Animals, Cells WHERE Animals.Number_Cell=Cells.Id) FROM Cells Where Cells.Id="+textBox_search.Text+" GROUP BY Cells.Id, Cells.Square, Cells.Kind;";
                    SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                    DataTable dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                }
                if (comboBox_search.Text == "Площадь клетки")
                {
                    prov = 1;
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    string zapros = "SELECT Cells.Id AS 'Номер клетки', Cells.Square AS 'Площадь клетки', Cells.Kind AS 'Вид клетки', 'Количество животных в клетке'=(SELECT Count(Animals.Id) FROM Animals, Cells WHERE Animals.Number_Cell=Cells.Id) FROM Cells Where Cells.Square=" + textBox_search.Text + " GROUP BY Cells.Id, Cells.Square, Cells.Kind;";
                    SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                    DataTable dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                }
                if (comboBox_search.Text == "Вид клетки")
                {
                    prov = 1;
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    string zapros = "SELECT Cells.Id AS 'Номер клетки', Cells.Square AS 'Площадь клетки', Cells.Kind AS 'Вид клетки', 'Количество животных в клетке'=(SELECT Count(Animals.Id) FROM Animals, Cells WHERE Animals.Number_Cell=Cells.Id) FROM Cells Where Cells.Kind Like N'%" + textBox_search.Text + "%' GROUP BY Cells.Id, Cells.Square, Cells.Kind;";
                    SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                    DataTable dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                }
                if (comboBox_search.Text == "Количество животных в клетке")
                {
                    prov = 1;
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    string zapros = "SELECT Cells.Id AS 'Номер клетки', Cells.Square AS 'Площадь клетки', Cells.Kind AS 'Вид клетки', (SELECT Count(Animals.Id) FROM Animals WHERE Animals.Number_Cell=Cells.Id) As 'Количество животных в клетке' FROM Cells GROUP BY Cells.Id, Cells.Square, Cells.Kind Having (SELECT Count(Animals.Id) FROM Animals WHERE Animals.Number_Cell=Cells.Id)=" + textBox_search.Text+";";
                    SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
                    DataTable dt = new DataTable();

                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            prov = 0;
            refresh();
        }

        private void button_filtr_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox_filtr.Text == "Номер клетки")
                {
                    prov = 1;
                    for(int i=0;i< dataGridView1.RowCount - 1; ++i)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == textBox_filtr.Text)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        }
                    }
                    
                }
                if (comboBox_filtr.Text == "Площадь клетки")
                {
                    prov = 1;
                    for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) == textBox_filtr.Text)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        }
                    }
                }
                if (comboBox_filtr.Text == "Вид клетки")
                {
                    prov = 1;
                    for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value).Trim() == textBox_filtr.Text)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        }
                    }
                }
                if (comboBox_filtr.Text == "Количество животных в клетке")
                {
                    prov = 1;
                    for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[3].Value)== textBox_filtr.Text)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);

            }
        }
    }
}
