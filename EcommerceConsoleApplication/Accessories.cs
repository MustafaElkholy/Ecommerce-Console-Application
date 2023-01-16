using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceConsoleApplication
{
    public enum Color
    {
        Red,
        Black,
        DarkBlue,
        Green
    
    }
    public enum AccessoryType
    {
        Cover,
        Headphone,
        Selfistick,

    }

    internal class Accessories : Product
    {
        public Color Color;
        public AccessoryType type;

        public Accessories(string name, double price, Color c , AccessoryType at) : base(name, price)
        {
            this.Color = c;
            this.type = at;
        }

        public override double GetTotalPrice()
        {
            return this.Price+ 5;
        }

    }

   
}
