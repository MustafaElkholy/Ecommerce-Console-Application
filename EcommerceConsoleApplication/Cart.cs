using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceConsoleApplication
{
    internal class Cart
    {
        private User Owner;
        private List<Product> myList = new List<Product>();

        public void AssignUser(User Owner)
        {
            this.Owner = Owner;
        }
        public void AddProduct(Product Product)
        {
            this.myList.Add(Product);
            Console.WriteLine($"You want to buy {Product.Name} and it costs {Product.Price}.");
        }

        public double CalculatePrice()
        {
            double totalPrice = 0;
            foreach (var product in myList)
            {
                totalPrice += product.GetTotalPrice();
            }
            return totalPrice;
        }
        public void Checkout()
        {
            double totalPrice = CalculatePrice();
            if (Owner.CheckBalance(totalPrice))
            {
                Owner.Withdraw(totalPrice);
                myList.Clear();
                Console.WriteLine("Thanks for using our site, Your products on the way.");
                
            }
            else
            {
                Console.WriteLine("You don't have enough balance.");
            }
        }

        public void Cancel()
        {
            myList.Clear();
        }
    }
}
