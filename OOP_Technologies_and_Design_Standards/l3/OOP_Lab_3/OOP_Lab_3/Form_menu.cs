using System;
using System.Windows.Forms;

namespace OOP_Lab_3
{
    public partial class Form_menu : Form
    {
        List listP = new List(8);
        int counter;
        public Form_menu()
        {
            InitializeComponent();
        }

        private void clip_Click(object sender, EventArgs e)
        {
            ChangeEverything();
        }

        private void button_sort_res_Click(object sender, EventArgs e)
        {
            SortClick();
            Time(listP, "Sort");
        }

        private void button_find_res_Click(object sender, EventArgs e)
        {
            FindClick();
            Time(listP, "Find");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            toolStripActual.Text = actual_number.Text = res_toolStrip.Text = result_actual_single.Text = "";
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindClickNoRadio(1);
            Time(listP, "Find");
        }
        private void nameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FindClickNoRadio(2);
            Time(listP, "Find");
        }
        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindClickNoRadio(3);
            Time(listP, "Find");
        }
        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortClickNoRadio(1);
            Time(listP, "Sort");
        }
        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortClickNoRadio(2);
            Time(listP, "Sort");
        }
        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortClickNoRadio(3);
            Time(listP, "Sort");
        }

        private void toolStripDown_Click(object sender, EventArgs e)
        {
            ++counter;
            if (counter < listP.GetCount())
            {
                PrintTheProduct(listP.products[counter]);
                actual_number.Text = toolStripActual.Text = (counter + 1).ToString();
            }
            else
                --counter;
        }
        private void toolStripUp_Click(object sender, EventArgs e)
        {
            --counter;
            if (counter >= 0)
            {
                PrintTheProduct(listP.products[counter]);
                actual_number.Text = toolStripActual.Text = (counter + 1).ToString();
            }
            else
                ++counter;
        }
        private void button_prev_Click(object sender, EventArgs e)
        {
            --counter;
            if (counter >= 0)
            {
                PrintTheProduct(listP.products[counter]);
                actual_number.Text = toolStripActual.Text = (counter + 1).ToString();
            }
            else
                ++counter;
        }
        private void button_next_Click(object sender, EventArgs e)
        {
            ++counter;
            if (counter < listP.GetCount())
            {
                PrintTheProduct(listP.products[counter]);
                actual_number.Text = toolStripActual.Text = (counter + 1).ToString();
            }
            else
                --counter;
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            SaveTheResult(listP);
        }

        private void menu_save_Click_1(object sender, EventArgs e)
        {
            SaveTheResult(listP);
        }
    }
}
