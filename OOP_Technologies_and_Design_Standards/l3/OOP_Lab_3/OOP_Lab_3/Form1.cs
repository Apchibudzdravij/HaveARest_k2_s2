using System;
using System.Windows.Forms;

namespace OOP_Lab_3
{
    public partial class Form1 : Form
    {
        bool isEmailed = false;
        bool isNamed = false;
        bool isSized = false;
        bool isDated = false;
        bool isModeled = false;
        public Form1()
        {
            InitializeComponent();
            APPLY.Enabled = false;
        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {
            if (!isEmailed)
                progressBar1.Value += 20;
            isEmailed = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isNamed)
                progressBar1.Value += 20;
            isNamed = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!isDated)
                progressBar1.Value += 20;
            isDated = true;
        }

        private void modelBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isModeled)
                progressBar1.Value += 20;
            isModeled = true;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isSized)
                progressBar1.Value += 20;
            isSized = true;
        }

        private void APPLY_Click(object sender, EventArgs e)
        {
            Applying();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            Saving();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
                APPLY.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_info activeInfo = new Form_info();
            activeInfo.Show();
            string mess = "Version: 0.0.2\nDYV";
            MessageBox.Show(mess);
        }

        private void FIND_Click(object sender, EventArgs e)
        {
            Form_menu new_query = new Form_menu();
            new_query.Show();
        }
    }
}
