using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceConsoleApplication
{
    internal abstract class Product
    {
        public string Name;
        public double Price;

        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual double GetTotalPrice()
        {
            return this.Price;
        }
    }
}
