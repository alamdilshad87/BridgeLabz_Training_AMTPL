using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Encapsulation
{
    internal class Account_Validation
    {
        private double balance;
        public void SetBalance(double amount)
        {
            if (amount >= 0)
                balance = amount;
            else
                Console.WriteLine("Invalid balance amount!");
        }
        public double GetBalance()
        {
            return balance;
        }
        static void Main()
        {
            Account_Validation acc = new Account_Validation();
            acc.SetBalance(5000);
            Console.WriteLine("Balance: " + acc.GetBalance());
            acc.SetBalance(-100);
        }
    }

}