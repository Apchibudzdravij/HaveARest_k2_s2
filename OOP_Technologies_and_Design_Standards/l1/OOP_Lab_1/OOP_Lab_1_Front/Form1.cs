using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace OOP_Lab_1_Front
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Clearing();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Saving();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            Sinus();
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            Cosinus();
        }

        private void button_tg_Click(object sender, EventArgs e)
        {
            Tangens();
        }

        private void button_ctg_Click(object sender, EventArgs e)
        {
            Cotangens();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            ToTwo();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            ToThree();
        }

        private void button_n_Click(object sender, EventArgs e)
        {
            ToN();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            Plusing();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            Minusing();
        }

        private void button_dir_Click(object sender, EventArgs e)
        {
            Dirslashing();
        }

        private void button_star_Click(object sender, EventArgs e)
        {
            Staring();
        }
    }
}
