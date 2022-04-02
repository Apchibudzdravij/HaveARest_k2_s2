using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace OOP_Lab_3
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
        [Required(ErrorMessage = "Model is required!", AllowEmptyStrings = false)]
        public string name;    //model
        [ID]
        public string id;      //model
        public string size;     //size
        public DateTime date;  //date
        [Required]
        [RegularExpression(@"^\w+$", ErrorMessage = "Name is unacceptable!")]
        public string customer { get; set; }//name
        [Required]
        [EmailAddress(ErrorMessage = "E-mail is wrong!")]
        public string email { get; set; }   //email
        [NonSerialized]
        double weight;  //size
        string type = "T-Shirt";
        [Range(0, 100, ErrorMessage = "Too much t-shirts")]
        int count;      //model
        float price;    //model
        Storekeeper mother;
        public Product(Storekeeper woman)
        {
            this.mother = woman;
            this.customer = "hg";
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
            result += this.customer + "\r\n";
            result += this.email + "\r\n";
            result += this.type + " ";
            result += this.count + "\r\n";
            result += this.name + " ";
            result += this.id + "\r\n";
            result += this.size.ToUpper() + " with weight: ";
            result += this.weight + "\r\n";
            result += this.date.ToLongDateString() + "\r\n";
            result += this.price;
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

    public class IDAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string id = value.ToString();
                if ((id.StartsWith("#"))&&(id.Length==4))
                    return true;
                else
                    this.ErrorMessage = "ID is unknown";
            }
            return false;
        }
    }
}
