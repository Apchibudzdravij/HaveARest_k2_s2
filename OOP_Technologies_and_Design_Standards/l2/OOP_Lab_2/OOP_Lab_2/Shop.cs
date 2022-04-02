using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_Lab_2
{
    interface IProduct
    {
        void AddEmail(string value);
        void AddName(string value);
        void AddSize(string sz, double weight);
        void AddModel(string nm, string d, int cnt, float prc);
        void AddDate(DateTime DtTm);
        string Show();
    }

    [Serializable]
    public class Product : IProduct
    {
        public string name;    //model
        public string id;      //model
        public string size;     //size
        public DateTime date;  //date
        public  string customer;//name
        public string email;   //email
        [NonSerialized]
        double weight;  //size
        string type = "T-Shirt";
        int count;      //model
        float price;    //model
        Storekeeper mother;
        public Product(Storekeeper woman)
        {
            this.mother = woman;
            this.customer = "";
            this.email = "";
            this.name = "";
            this.id = "";
            this.size = "S";
            this.weight = 0.0;
            this.date = DateTime.Now;
            this.count = 0;
            this.price = 0;
        }
        public Product()
        {
            this.mother = null;
            this.customer = "";
            this.email = "";
            this.name = "";
            this.id = "";
            this.size = "S";
            this.weight = 0.0;
            this.date = DateTime.Now;
            this.count = 0;
            this.price = 0;
        }
        public void AddEmail(string value) { this.email = value; }
        public void AddName(string value) { this.customer = value; }
        public void AddSize(string sz, double wght)
        {
            this.size = sz; this.weight = wght;
        }
        public void AddModel(string nm, string d, int cnt, float prc)
        {
            this.name = nm; this.id = d; this.count = cnt; this.price = prc;
        }
        public void AddDate(DateTime DtTm) { this.date = DtTm; }
        public string Show()
        {
            string result = "";
            result += this.customer + "\n";
            result += this.email + "\n";
            result += this.type + "\n";
            result += this.name + "\n";
            result += this.id + "\n";
            result += this.size.ToUpper() + "\n";
            result += this.weight + "\n";
            result += this.date.ToLongDateString() + "\n";
            result += this.count + "\n";
            result += this.price + "\n";
            return result;
        }
    }

    public class Storekeeper
    {
        string name;
        int experience;
        string address;
        public Storekeeper(string nm, int xprnc, string ddrs)
        {
            this.name = nm; this.experience = xprnc; this.address = ddrs;
        }
    }
}
