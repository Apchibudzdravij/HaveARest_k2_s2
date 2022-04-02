using System;
using System.Xml.Serialization;
using System.IO;

namespace OOP_Lab_3
{
    interface IListable
    {
        string GetTime();
        int GetCount();
        void FillTheList();
    }
    [Serializable]
    public class List : IListable
    {
        public Product[] products;
        private int size;
        [NonSerialized]
        private int counter;
        private List()
        {
            this.counter = 5;
            this.size = 0;
            this.products = new Product[5];
        }
        public List(int number_of_notes)
        {
            this.counter = number_of_notes;
            this.size = 0;
            this.products = new Product[number_of_notes];
        }
        public void Add(Product p)
        {
            if (this.size < this.counter)
            {
                this.products[this.size] = p;
                ++this.size;
            }
        }
        public string GetTime()
        {
            return new DateTime().ToString();
        }
        public int GetCount()
        {
            return this.counter;
        }
        public int GetSize()
        {
            return this.size;
        }
        public void FillTheList()
        {
            XmlSerializer XMLmatter = new XmlSerializer(typeof(Product));
            for (int i = 0; i < this.GetCount(); ++i)
            {
                string src = "D:\\ExtendedData\\Laboratory\\ООТПиСП\\l3\\OOP_Lab_3\\stratification\\m";
                src += (i + 1).ToString();
                src += ".xml";
                using (FileStream fx = new FileStream(src, FileMode.OpenOrCreate))
                {
                    this.products[i] = XMLmatter.Deserialize(fx) as Product;
                }
            }
            this.size = this.GetCount();
        }
    }
}
