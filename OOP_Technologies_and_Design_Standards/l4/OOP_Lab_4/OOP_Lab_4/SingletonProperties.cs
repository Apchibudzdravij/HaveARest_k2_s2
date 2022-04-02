using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_4
{
    public sealed class SingletonProperties
    {
        private static readonly SingletonProperties Instance = new SingletonProperties();
        private static string _color;
        private static string _font;
        private static int _poles;
        static SingletonProperties()
        {
            _color = "Control";
            _font = "Showcard Gothic";
            _poles = 5;
        }
        private SingletonProperties() { }
        public static SingletonProperties GetInstance()
        {
            return Instance;
        }
        public string GetProps()
        {
            string str = "Background color is " + _color;
            str += ".\r\nFont is " + _font;
            str += ".\r\nNumber of fields is " + _poles + ".";
            return str;
        }
    }
}
