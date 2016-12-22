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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Course_BD
{
    public partial class Gabela : Form
    {
        const string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\VS2015\DZ\Course_BD\Course_BD\ZOO.mdf; Integrated Security = True";

        public Gabela()
        {
            InitializeComponent();
        }

        private void button_f_otchet_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string zapros = "SELECT F_Name As 'Имя', S_Name As 'Фамилия', Id As 'Номер', Work_Start As 'Начало работы' From Wards Where Work_Start Like '__."+textBox_month.Text+"."+textBox_year.Text+"' ";
            SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
            DataSet dt = new DataSet();

            oda.Fill(dt);
            
            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            //Создаем объект записи пдф-документа в файл
            PdfWriter.GetInstance(doc, new FileStream("zapros_1.pdf", FileMode.Create));

            //Открываем документ
            doc.Open();

            //Определение шрифта необходимо для сохранения кириллического текста
            //Иначе мы не увидим кириллический текст
            //Если мы работаем только с англоязычными текстами, то шрифт можно не указывать
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            //Обход по всем таблицам датасета (хотя в данном случае мы можем опустить
            //Так как в нашей бд только одна таблица)
            for (int i = 0; i < dt.Tables.Count; i++)
            {
                //Создаем объект таблицы и передаем в нее число столбцов таблицы из нашего датасета
                PdfPTable table = new PdfPTable(dt.Tables[i].Columns.Count);

                //Добавим в таблицу общий заголовок
                PdfPCell cell = new PdfPCell(new Phrase("Cотрудники начавшие работать с"+textBox_month.Text+" месяца " + textBox_year.Text+" года", font));

                cell.Colspan = dt.Tables[i].Columns.Count;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы балы как заголовок
                cell.Border = 0;
                table.AddCell(cell);

                //Сначала добавляем заголовки таблицы
                for (int j = 0; j < dt.Tables[i].Columns.Count; j++)
                {
                    cell = new PdfPCell(new Phrase(new Phrase(dt.Tables[i].Columns[j].ColumnName, font)));
                    //Фоновый цвет (необязательно, просто сделаем по красивее)
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                //Добавляем все остальные ячейки
                for (int j = 0; j < dt.Tables[i].Rows.Count; j++)
                {
                    for (int k = 0; k < dt.Tables[i].Columns.Count; k++)
                    {
                        table.AddCell(new Phrase(dt.Tables[i].Rows[j][k].ToString(), font));
                    }
                }
                //Добавляем таблицу в документ
                doc.Add(table);
            }
            //Закрываем документ
            doc.Close();

            MessageBox.Show("Pdf-документ сохранен");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string zapros = "Select Animals.Kind As 'Виды животных', Count(Id) As 'Количество животных данного вида' From Animals Group By Kind";
            SqlDataAdapter oda = new SqlDataAdapter(zapros, sqlconn);
            DataSet dt = new DataSet();

            oda.Fill(dt);

            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            //Создаем объект записи пдф-документа в файл
            PdfWriter.GetInstance(doc, new FileStream("zapros_2.pdf", FileMode.Create));

            //Открываем документ
            doc.Open();

            //Определение шрифта необходимо для сохранения кириллического текста
            //Иначе мы не увидим кириллический текст
            //Если мы работаем только с англоязычными текстами, то шрифт можно не указывать
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            //Обход по всем таблицам датасета (хотя в данном случае мы можем опустить
            //Так как в нашей бд только одна таблица)
            for (int i = 0; i < dt.Tables.Count; i++)
            {
                //Создаем объект таблицы и передаем в нее число столбцов таблицы из нашего датасета
                PdfPTable table = new PdfPTable(dt.Tables[i].Columns.Count);

                //Добавим в таблицу общий заголовок
                PdfPCell cell = new PdfPCell(new Phrase("Виды животных в зоопарке", font));

                cell.Colspan = dt.Tables[i].Columns.Count;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы балы как заголовок
                cell.Border = 0;
                table.AddCell(cell);

                //Сначала добавляем заголовки таблицы
                for (int j = 0; j < dt.Tables[i].Columns.Count; j++)
                {
                    cell = new PdfPCell(new Phrase(new Phrase(dt.Tables[i].Columns[j].ColumnName, font)));
                    //Фоновый цвет (необязательно, просто сделаем по красивее)
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                //Добавляем все остальные ячейки
                for (int j = 0; j < dt.Tables[i].Rows.Count; j++)
                {
                    for (int k = 0; k < dt.Tables[i].Columns.Count; k++)
                    {
                        table.AddCell(new Phrase(dt.Tables[i].Rows[j][k].ToString(), font));
                    }
                }
                //Добавляем таблицу в документ
                doc.Add(table);
            }
            //Закрываем документ
            doc.Close();

            MessageBox.Show("Pdf-документ сохранен");
        }
    }
}
