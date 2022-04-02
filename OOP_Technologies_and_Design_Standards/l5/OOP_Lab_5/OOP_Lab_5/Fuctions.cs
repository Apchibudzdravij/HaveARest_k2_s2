using System;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.IO;

namespace OOP_Lab_4
{
    interface IXMLSaveable
    {
        void Applying();
        void Saving();
        void Loading();
    }

    public partial class Form1: IXMLSaveable
    {
        public void Undo(TShirtState ts)
        {
            validation.Text = ts.Data;
        }
        public void Single()
        {
            pictureBox1.Visible = false;
            validation.Text = SingletonProperties.GetInstance().GetProps();
        }
        public void Applying()
        {
            pictureBox1.Visible = false;
            if (!Regex.IsMatch(emailbox.Text, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase))
            {
                validation.Text = "E-mail is wrong!";
                return;
            }
            IFactory factory = new TShirtFactory();
            var currentProduct = factory.CreateTShirt();
            var productBuilder = new ProductBuilder();
            switch (listBox1.SelectedItem.ToString())
            {
                case "s": currentProduct.AddSize(listBox1.SelectedItem.ToString(), 1.0); break;
                case "m": currentProduct.AddSize(listBox1.SelectedItem.ToString(), 2.0); break;
                case "l": currentProduct.AddSize(listBox1.SelectedItem.ToString(), 3.5); break;
                case "xl": currentProduct.AddSize(listBox1.SelectedItem.ToString(), 6.75); break;
                default: currentProduct.AddSize("S", 1.0); break;
            }
            currentProduct.AddName(textBox1.Text);
            currentProduct.AddEmail(emailbox.Text);
            currentProduct.AddDate(dateTimePicker1.Value);
            string[] words = modelBox1.Text.Split(' ');
            currentProduct.AddModel(words[0], words[1], 24);
            var clone = currentProduct.Clone();
            IProduct notClone = new ShopWithDecoration(clone);
/*!*/       validation.Text = notClone.Show();
        }

        public void Saving()
        {
            IFactory factory = new TShirtFactory();
            var currentProduct = factory.CreateTShirt();
            switch (listBox1.SelectedItem.ToString())
            {
                case "s": currentProduct.AddSize(listBox1.SelectedItem.ToString(), 1.0); break;
                case "m": currentProduct.AddSize(listBox1.SelectedItem.ToString(), 2.0); break;
                case "l": currentProduct.AddSize(listBox1.SelectedItem.ToString(), 3.5); break;
                case "xl": currentProduct.AddSize(listBox1.SelectedItem.ToString(), 6.75); break;
                default: currentProduct.AddSize("s", 1.0); break;
            }
            currentProduct.AddName(textBox1.Text);
            currentProduct.AddEmail(emailbox.Text);
            currentProduct.AddDate(dateTimePicker1.Value);
            string[] words = modelBox1.Text.Split(' ');
            currentProduct.AddModel(words[0], words[1], 24);

            File.Delete("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l2\\OOP_Lab_2\\memory.xml");
            XmlSerializer XMLmatter = new XmlSerializer(typeof(Product));
            using (FileStream fx = new FileStream("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l2\\OOP_Lab_2\\memory.xml", FileMode.OpenOrCreate))
            {
                XMLmatter.Serialize(fx, currentProduct);
            }
        }

        public void Loading()
        {
            XmlSerializer XMLmatter = new XmlSerializer(typeof(Product));
            using (FileStream fx = new FileStream("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l2\\OOP_Lab_2\\memory.xml", FileMode.OpenOrCreate))
            {
                Product currentProduct = XMLmatter.Deserialize(fx) as Product;
                textBox1.Text = currentProduct.customer;
                emailbox.Text = currentProduct.email;
                dateTimePicker1.Value = currentProduct.date;
                modelBox1.Text = currentProduct.name + " " + currentProduct.id;
                listBox1.SelectedIndex = listBox1.FindString(currentProduct.size);
            }
        }
    }
}
