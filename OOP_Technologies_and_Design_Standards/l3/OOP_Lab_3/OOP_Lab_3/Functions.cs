using System;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace OOP_Lab_3
{
    interface IXMLSaveable
    {
        void Applying();
        void Saving();
        void Loading();
    }

    public partial class Form1 : IXMLSaveable
    {
        public void Applying()
        {
            pictureBox1.Visible = false;
            Storekeeper storekeeper = new Storekeeper("Ivan", 4, "ul.Pervaja, 14-2");
            Product currentProduct = new Product(storekeeper);
            //var context = new ValidationContext(currentProduct);
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
            currentProduct.AddModel(words[0], words[1], 24, 46.99f);
            
            var ressult = new List<ValidationResult>();
            var context = new ValidationContext(currentProduct);
            var val = !Validator.TryValidateObject(currentProduct, context, ressult, true);
            if (val)
            {
                validation.Text = "";
                foreach (var error in ressult)
                {
                    validation.Text += error.ErrorMessage + "\r\n";
                }
                return;
            }
            else
                validation.Text = currentProduct.Show();
        }

        public void Saving()
        {
            Storekeeper storekeeper = new Storekeeper("Ivan", 4, "ul.Pervaja, 14-2");
            Product currentProduct = new Product(storekeeper);
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
            currentProduct.AddModel(words[0], words[1], 24, 46.99f);

            XmlSerializer XMLmatter = new XmlSerializer(typeof(Product));
            using (FileStream fx = new FileStream("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l3\\OOP_Lab_3\\memory.xml", FileMode.OpenOrCreate))
            {
                XMLmatter.Serialize(fx, currentProduct);
            }
        }

        public void Loading()
        {
            XmlSerializer XMLmatter = new XmlSerializer(typeof(Product));
            using (FileStream fx = new FileStream("D:\\ExtendedData\\Laboratory\\ООТПиСП\\l3\\OOP_Lab_3\\memory.xml", FileMode.OpenOrCreate))
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
