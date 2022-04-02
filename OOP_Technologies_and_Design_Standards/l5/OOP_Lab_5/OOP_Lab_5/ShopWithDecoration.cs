using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_4
{
    class ShopWithDecoration : PrDec
    {
        public ShopWithDecoration(IProduct component) : base(component) { }
        public override string Show()
        {
            Component.name += @"/|\";
            Component.id += "#";
            return base.Show();
        }
    }
}
