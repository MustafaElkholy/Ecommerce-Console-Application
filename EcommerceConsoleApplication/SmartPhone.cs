using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceConsoleApplication
{
    public enum OperatingSystem
    {
        Android,
        IOS
    }
    internal class SmartPhone : Product
    {
        public int ProductionYear;
        public OperatingSystem OS;

        public SmartPhone(string name, double price, int Pyear, OperatingSystem os) : base(name, price)
        { 
            ProductionYear = Pyear;
            OS = os;
            
        }

        public override double GetTotalPrice()
        {
            return this.Price + 10;
        }

    }
}
