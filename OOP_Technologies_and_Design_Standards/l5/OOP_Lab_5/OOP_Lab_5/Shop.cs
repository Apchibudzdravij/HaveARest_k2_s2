using System;

namespace OOP_Lab_4
{
    interface IProducter
    {
        void AddEmail(string value);
        void AddName(string value);
        void AddSize(string sz, double weight);
        void AddModel(string nm, string d, int cnt);
        void AddDate(DateTime DtTm);
        string Show();
    }

    [Serializable]
    public class Product : Prototype<Product>, IProduct, IProducter, ITShirt
    {
        public string name { get; set; }    //model
        public string id { get; set; }     //model
        public string size;     //size
        public DateTime date;  //date
        public  string customer;//name
        public string email;   //email
        [NonSerialized]
        public double weight;  //size
        string type = "T-Shirt";
        int count;      //model
        public float Price => 46.66f;    //model
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
        }
        public void AddEmail(string value) { this.email = value; }
        public void AddName(string value) { this.customer = value; }
        public void AddSize(string sz, double wght)
        {
            this.size = sz; this.weight = wght;
        }
        public void AddModel(string nm, string d, int cnt)
        {
            this.name = nm; this.id = d; this.count = cnt;
        }
        public void AddDate(DateTime DtTm) { this.date = DtTm; }
        public string Show()
        {
            string result = "";
            result += this.customer + "\r\n";
            result += this.email + "\r\n";
            result += this.type + " ";
            result += this.name + " ";
            result += this.id + "\r\n";
            result += this.size.ToUpper() + " ";
            result += this.weight + "\r\n";
            result += this.date.ToLongDateString() + "\r\n";
            //result += this.count + "\r\n";
            result += this.Price;
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
