using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_BD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animals form = new Animals();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Wards form = new Wards();
            form.ShowDialog();
        }

        private void button_cells_Click(object sender, EventArgs e)
        {
            Cells form = new Cells();
            form.ShowDialog();
        }

        private void button_statik_Click(object sender, EventArgs e)
        {
            Statikcs form = new Statikcs();
            form.ShowDialog();
        }

        private void button_gabela_Click(object sender, EventArgs e)
        {
            Gabela form = new Gabela();
            form.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
