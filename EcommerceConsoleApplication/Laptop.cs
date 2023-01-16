using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceConsoleApplication
{
    internal class Laptop : Product
    {
        public string Company;
        public double Weight;

        public Laptop(string name, double price, string company , double weight) : base(name, price)
        {
            this.Company= company;
            this.Weight= weight;
        }

        public override double GetTotalPrice()
        {
            return this.Price + 15 + Weight * 5;
        }
    }
}
