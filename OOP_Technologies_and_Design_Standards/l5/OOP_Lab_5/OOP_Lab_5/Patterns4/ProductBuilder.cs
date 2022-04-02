using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_4
{
    public interface IProductBuilder
    {
        IProductBuilder BuildEmail(string value);
        IProductBuilder BuildName(string value);
        IProductBuilder BuildModel(string nm, string d);
        IProductBuilder BuildSize(string sz, double wght);
        IProductBuilder BuildDate(DateTime DtTm);
        IProductBuilder BuildPrice();
        string GetResult();
    }

    public class ProductBuilder : IProductBuilder
    {
        private string _prod = string.Empty;

        public IProductBuilder BuildEmail(string value)
        {
            _prod += value + Environment.NewLine;
            return this;
        }
        public IProductBuilder BuildName(string value)
        {
            _prod += value + Environment.NewLine;
            return this;
        }
        public IProductBuilder BuildModel(string nm, string d)
        {
            _prod += nm + ' ';
            _prod += d + Environment.NewLine;
            return this;
        }
        public IProductBuilder BuildSize(string sz, double wght)
        {
            _prod += sz.ToUpper() + ' ';
            _prod += wght + Environment.NewLine;
            return this;
        }
        public IProductBuilder BuildDate(DateTime DtTm)
        {
            _prod += DtTm.ToLongDateString() + Environment.NewLine;
            return this;
        }
        public IProductBuilder BuildPrice()
        {
            _prod += 46.66f.ToString();
            return this;
        }
        public string GetResult()
        {
            return _prod;
        }
    }
}
