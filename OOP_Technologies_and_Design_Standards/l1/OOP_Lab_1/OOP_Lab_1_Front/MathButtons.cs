using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_Lab_1_Front
{
    interface ICalc
    {
        void Clearing();
        void Sinus();
        void Cosinus();
        void Tangens();
        void Cotangens();
        void ToTwo();
        void ToThree();
        void ToN();
        void Plusing();
        void Minusing();
        void Staring();
        void Dirslashing();
        void Saving();
        void Loading();
    }
    /*public delegate void sinus();
    public delegate void cosinus();
    public delegate void tangens();
    public delegate void cotangens();
    public delegate void summ();
    public delegate void substract();
    public delegate void multiply();
    public delegate void divide();
    public delegate void square();
    public delegate void cube();
    public delegate void power();
    public delegate void memory();
    public delegate void unmemory();
    public delegate void clear();*/
    public partial class Calculator : ICalc
    {
        public void Clearing()
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
            textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = "";
        }
        public void Sinus()
        {
            string temp;
            double sence;
            if (textBox1.Text != "")
            {
                temp = textBox1.Text;
                sence = Double.Parse(temp);
                sence = Math.Sin(sence);
                textBox1.Text = sence.ToString("F");
            }
            if (textBox2.Text != "")
            {
                temp = textBox2.Text;
                sence = Double.Parse(temp);
                sence = Math.Sin(sence);
                textBox2.Text = sence.ToString("F");
            }
            if (textBox3.Text != "")
            {
                temp = textBox3.Text;
                sence = Double.Parse(temp);
                sence = Math.Sin(sence);
                textBox3.Text = sence.ToString("F");
            }
            if (textBox4.Text != "")
            {
                temp = textBox4.Text;
                sence = Double.Parse(temp);
                sence = Math.Sin(sence);
                textBox4.Text = sence.ToString("F");
            }
            if (textBox5.Text != "")
            {
                temp = textBox5.Text;
                sence = Double.Parse(temp);
                sence = Math.Sin(sence);
                textBox5.Text = sence.ToString("F");
            }
            if (textBox6.Text != "")
            {
                temp = textBox6.Text;
                sence = Double.Parse(temp);
                sence = Math.Sin(sence);
                textBox6.Text = sence.ToString("F");
            }
            if (textBox7.Text != "")
            {
                temp = textBox7.Text;
                sence = Double.Parse(temp);
                sence = Math.Sin(sence);
                textBox7.Text = sence.ToString("F");
            }
            if (textBox8.Text != "")
            {
                temp = textBox8.Text;
                sence = Double.Parse(temp);
                sence = Math.Sin(sence);
                textBox8.Text = sence.ToString("F");
            }
            if (textBox9.Text != "")
            {
                temp = textBox9.Text;
                sence = Double.Parse(temp);
                sence = Math.Sin(sence);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void Cosinus()
        {
            string temp;
            double sence;
            if (textBox1.Text != "")
            {
                temp = textBox1.Text;
                sence = Double.Parse(temp);
                sence = Math.Cos(sence);
                textBox1.Text = sence.ToString("F");
            }
            if (textBox2.Text != "")
            {
                temp = textBox2.Text;
                sence = Double.Parse(temp);
                sence = Math.Cos(sence);
                textBox2.Text = sence.ToString("F");
            }
            if (textBox3.Text != "")
            {
                temp = textBox3.Text;
                sence = Double.Parse(temp);
                sence = Math.Cos(sence);
                textBox3.Text = sence.ToString("F");
            }
            if (textBox4.Text != "")
            {
                temp = textBox4.Text;
                sence = Double.Parse(temp);
                sence = Math.Cos(sence);
                textBox4.Text = sence.ToString("F");
            }
            if (textBox5.Text != "")
            {
                temp = textBox5.Text;
                sence = Double.Parse(temp);
                sence = Math.Cos(sence);
                textBox5.Text = sence.ToString("F");
            }
            if (textBox6.Text != "")
            {
                temp = textBox6.Text;
                sence = Double.Parse(temp);
                sence = Math.Cos(sence);
                textBox6.Text = sence.ToString("F");
            }
            if (textBox7.Text != "")
            {
                temp = textBox7.Text;
                sence = Double.Parse(temp);
                sence = Math.Cos(sence);
                textBox7.Text = sence.ToString("F");
            }
            if (textBox8.Text != "")
            {
                temp = textBox8.Text;
                sence = Double.Parse(temp);
                sence = Math.Cos(sence);
                textBox8.Text = sence.ToString("F");
            }
            if (textBox9.Text != "")
            {
                temp = textBox9.Text;
                sence = Double.Parse(temp);
                sence = Math.Cos(sence);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void Tangens()
        {
            string temp;
            double sence;
            if (textBox1.Text != "")
            {
                temp = textBox1.Text;
                sence = Double.Parse(temp);
                sence = Math.Tan(sence);
                textBox1.Text = sence.ToString("F");
            }
            if (textBox2.Text != "")
            {
                temp = textBox2.Text;
                sence = Double.Parse(temp);
                sence = Math.Tan(sence);
                textBox2.Text = sence.ToString("F");
            }
            if (textBox3.Text != "")
            {
                temp = textBox3.Text;
                sence = Double.Parse(temp);
                sence = Math.Tan(sence);
                textBox3.Text = sence.ToString("F");
            }
            if (textBox4.Text != "")
            {
                temp = textBox4.Text;
                sence = Double.Parse(temp);
                sence = Math.Tan(sence);
                textBox4.Text = sence.ToString("F");
            }
            if (textBox5.Text != "")
            {
                temp = textBox5.Text;
                sence = Double.Parse(temp);
                sence = Math.Tan(sence);
                textBox5.Text = sence.ToString("F");
            }
            if (textBox6.Text != "")
            {
                temp = textBox6.Text;
                sence = Double.Parse(temp);
                sence = Math.Tan(sence);
                textBox6.Text = sence.ToString("F");
            }
            if (textBox7.Text != "")
            {
                temp = textBox7.Text;
                sence = Double.Parse(temp);
                sence = Math.Tan(sence);
                textBox7.Text = sence.ToString("F");
            }
            if (textBox8.Text != "")
            {
                temp = textBox8.Text;
                sence = Double.Parse(temp);
                sence = Math.Tan(sence);
                textBox8.Text = sence.ToString("F");
            }
            if (textBox9.Text != "")
            {
                temp = textBox9.Text;
                sence = Double.Parse(temp);
                sence = Math.Tan(sence);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void Cotangens()
        {
            string temp;
            double sence;
            if (textBox1.Text != "")
            {
                temp = textBox1.Text;
                sence = Double.Parse(temp);
                sence = 1.0 / Math.Tan(sence);
                textBox1.Text = sence.ToString("F");
            }
            if (textBox2.Text != "")
            {
                temp = textBox2.Text;
                sence = Double.Parse(temp);
                sence = 1.0 / Math.Tan(sence);
                textBox2.Text = sence.ToString("F");
            }
            if (textBox3.Text != "")
            {
                temp = textBox3.Text;
                sence = Double.Parse(temp);
                sence = 1.0 / Math.Tan(sence);
                textBox3.Text = sence.ToString("F");
            }
            if (textBox4.Text != "")
            {
                temp = textBox4.Text;
                sence = Double.Parse(temp);
                sence = 1.0 / Math.Tan(sence);
                textBox4.Text = sence.ToString("F");
            }
            if (textBox5.Text != "")
            {
                temp = textBox5.Text;
                sence = Double.Parse(temp);
                sence = 1.0 / Math.Tan(sence);
                textBox5.Text = sence.ToString("F");
            }
            if (textBox6.Text != "")
            {
                temp = textBox6.Text;
                sence = Double.Parse(temp);
                sence = 1.0 / Math.Tan(sence);
                textBox6.Text = sence.ToString("F");
            }
            if (textBox7.Text != "")
            {
                temp = textBox7.Text;
                sence = Double.Parse(temp);
                sence = 1.0 / Math.Tan(sence);
                textBox7.Text = sence.ToString("F");
            }
            if (textBox8.Text != "")
            {
                temp = textBox8.Text;
                sence = Double.Parse(temp);
                sence = 1.0 / Math.Tan(sence);
                textBox8.Text = sence.ToString("F");
            }
            if (textBox9.Text != "")
            {
                temp = textBox9.Text;
                sence = Double.Parse(temp);
                sence = 1.0 / Math.Tan(sence);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void ToTwo()
        {
            string temp;
            double sence;
            if (textBox1.Text != "")
            {
                temp = textBox1.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 2.0);
                textBox1.Text = sence.ToString("F");
            }
            if (textBox2.Text != "")
            {
                temp = textBox2.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 2.0);
                textBox2.Text = sence.ToString("F");
            }
            if (textBox3.Text != "")
            {
                temp = textBox3.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 2.0);
                textBox3.Text = sence.ToString("F");
            }
            if (textBox4.Text != "")
            {
                temp = textBox4.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 2.0);
                textBox4.Text = sence.ToString("F");
            }
            if (textBox5.Text != "power of second and writes the result to the third column")
            {
                temp = textBox5.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 2.0);
                textBox5.Text = sence.ToString("F");
            }
            if (textBox6.Text != "")
            {
                temp = textBox6.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 2.0);
                textBox6.Text = sence.ToString("F");
            }
            if (textBox7.Text != "")
            {
                temp = textBox7.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 2.0);
                textBox7.Text = sence.ToString("F");
            }
            if (textBox8.Text != "")
            {
                temp = textBox8.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 2.0);
                textBox8.Text = sence.ToString("F");
            }
            if (textBox9.Text != "")
            {
                temp = textBox9.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 2.0);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void ToThree()
        {
            string temp;
            double sence;
            if (textBox1.Text != "")
            {
                temp = textBox1.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 3.0);
                textBox1.Text = sence.ToString("F");
            }
            if (textBox2.Text != "")
            {
                temp = textBox2.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 3.0);
                textBox2.Text = sence.ToString("F");
            }
            if (textBox3.Text != "")
            {
                temp = textBox3.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 3.0);
                textBox3.Text = sence.ToString("F");
            }
            if (textBox4.Text != "")
            {
                temp = textBox4.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 3.0);
                textBox4.Text = sence.ToString("F");
            }
            if (textBox5.Text != "")
            {
                temp = textBox5.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 3.0);
                textBox5.Text = sence.ToString("F");
            }
            if (textBox6.Text != "")
            {
                temp = textBox6.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 3.0);
                textBox6.Text = sence.ToString("F");
            }
            if (textBox7.Text != "")
            {
                temp = textBox7.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 3.0);
                textBox7.Text = sence.ToString("F");
            }
            if (textBox8.Text != "")
            {
                temp = textBox8.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 3.0);
                textBox8.Text = sence.ToString("F");
            }
            if (textBox9.Text != "")
            {
                temp = textBox9.Text;
                sence = Double.Parse(temp);
                sence = Math.Pow(sence, 3.0);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void ToN()
        {
            double sence;
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                sence = Double.Parse(textBox1.Text);
                sence = Math.Pow(sence, Double.Parse(textBox2.Text));
                textBox3.Text = sence.ToString("F");
            }
            if ((textBox4.Text != "") && (textBox5.Text != ""))
            {
                sence = Double.Parse(textBox4.Text);
                sence = Math.Pow(sence, Double.Parse(textBox5.Text));
                textBox6.Text = sence.ToString("F");
            }
            if ((textBox7.Text != "") && (textBox8.Text != ""))
            {
                sence = Double.Parse(textBox7.Text);
                sence = Math.Pow(sence, Double.Parse(textBox8.Text));
                textBox9.Text = sence.ToString("F");
            }
        }
        public void Plusing()
        {
            double sence;
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                sence = Double.Parse(textBox1.Text);
                sence += Double.Parse(textBox2.Text);
                textBox3.Text = sence.ToString("F");
            }
            if ((textBox4.Text != "") && (textBox5.Text != ""))
            {
                sence = Double.Parse(textBox4.Text);
                sence += Double.Parse(textBox5.Text);
                textBox6.Text = sence.ToString("F");
            }
            if ((textBox7.Text != "") && (textBox8.Text != ""))
            {
                sence = Double.Parse(textBox7.Text);
                sence += Double.Parse(textBox8.Text);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void Minusing()
        {
            double sence;
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                sence = Double.Parse(textBox1.Text);
                sence -= Double.Parse(textBox2.Text);
                textBox3.Text = sence.ToString("F");
            }
            if ((textBox4.Text != "") && (textBox5.Text != ""))
            {
                sence = Double.Parse(textBox4.Text);
                sence -= Double.Parse(textBox5.Text);
                textBox6.Text = sence.ToString("F");
            }
            if ((textBox7.Text != "") && (textBox8.Text != ""))
            {
                sence = Double.Parse(textBox7.Text);
                sence -= Double.Parse(textBox8.Text);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void Staring()
        {
            double sence;
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                sence = Double.Parse(textBox1.Text);
                sence *= Double.Parse(textBox2.Text);
                textBox3.Text = sence.ToString("F");
            }
            if ((textBox4.Text != "") && (textBox5.Text != ""))
            {
                sence = Double.Parse(textBox4.Text);
                sence *= Double.Parse(textBox5.Text);
                textBox6.Text = sence.ToString("F");
            }
            if ((textBox7.Text != "") && (textBox8.Text != ""))
            {
                sence = Double.Parse(textBox7.Text);
                sence *= Double.Parse(textBox8.Text);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void Dirslashing()
        {
            double sence;
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                sence = Double.Parse(textBox1.Text);
                sence /= Double.Parse(textBox2.Text);
                textBox3.Text = sence.ToString("F");
            }
            if ((textBox4.Text != "") && (textBox5.Text != ""))
            {
                sence = Double.Parse(textBox4.Text);
                sence /= Double.Parse(textBox5.Text);
                textBox6.Text = sence.ToString("F");
            }
            if ((textBox7.Text != "") && (textBox8.Text != ""))
            {
                sence = Double.Parse(textBox7.Text);
                sence /= Double.Parse(textBox8.Text);
                textBox9.Text = sence.ToString("F");
            }
        }
        public void Saving()
        {
            File.Delete("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l1\\OOP_Lab_1\\memory.calculator");
            StreamWriter stream = new StreamWriter("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l1\\OOP_Lab_1\\memory.calculator", true);
            stream.WriteLine(textBox1.Text);
            stream.WriteLine(textBox2.Text);
            stream.WriteLine(textBox3.Text);
            stream.WriteLine(textBox4.Text);
            stream.WriteLine(textBox5.Text);
            stream.WriteLine(textBox6.Text);
            stream.WriteLine(textBox7.Text);
            stream.WriteLine(textBox8.Text);
            stream.WriteLine(textBox9.Text);
            stream.Close();
        }
        public void Loading()
        {
            if (File.Exists("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l1\\OOP_Lab_1\\memory.calculator"))
            {
                StreamReader stream = new StreamReader("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l1\\OOP_Lab_1\\memory.calculator", true);
                textBox1.Text = stream.ReadLine();
                textBox2.Text = stream.ReadLine();
                textBox3.Text = stream.ReadLine();
                textBox4.Text = stream.ReadLine();
                textBox5.Text = stream.ReadLine();
                textBox6.Text = stream.ReadLine();
                textBox7.Text = stream.ReadLine();
                textBox8.Text = stream.ReadLine();
                textBox9.Text = stream.ReadLine();
                stream.Close();
            }
        }
    }
}
