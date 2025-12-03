using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Abstraction.Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saving Account:");
            BankApp savingAccount = new SavingAccount();
            savingAccount.DepositAmount(2000);
            savingAccount.DepositAmount(1000);
            savingAccount.WithdrawAmount(1500);
            savingAccount.WithdrawAmount(5000);
            Console.WriteLine($"Saving Account Balanace: {savingAccount.CheckBalance()}");

            Console.WriteLine("\nCurrent Account:");
            BankApp currentAccount = new CurrentAccount();
            currentAccount.DepositAmount(500);
            currentAccount.DepositAmount(1500);
            currentAccount.WithdrawAmount(2600);
            currentAccount.WithdrawAmount(1000);
            Console.WriteLine($"Current Account Balanace: {currentAccount.CheckBalance()}");
            Console.ReadLine();
        }
    }
}
