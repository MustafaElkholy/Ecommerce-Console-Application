using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceConsoleApplication
{

    internal class User
    {
        public string UserName;
        private string Password;
        private double balance;

        public User(string userName, string password,double balance)
        {
            this.UserName = userName;
            this.Password = password;
            this.balance = balance;
        }
        public void AddBalance(double balance)
        {
            this.balance += balance;
        }
        public void Withdraw(double balance)
        {
            this.balance -= balance;
        }

        public void SetPassword(string password)
        {
            this.Password = password;
        }
        public bool CheckPassword(string str)
        {
            return str == this.Password ? true: false;
        }
        //public bool CheckBalance(int amount)
        //{
        //  return this.balance >= amount? true: false;   
        //}
        public bool CheckBalance(double amount) =>  this.balance >= amount ? true : false;
        
    }
}
