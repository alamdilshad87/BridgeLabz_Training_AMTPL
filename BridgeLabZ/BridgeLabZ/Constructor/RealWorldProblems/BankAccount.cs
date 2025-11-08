using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Constructor.RealWorldProblems
{
    internal class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public string AccountType;
        public double Balance;
        public static string BankName;
        private static int nextAccountNumber = 1001;
        static BankAccount()
        {
            BankName = "State Bank of India";
            Console.WriteLine("Bank System Initialized for: " + BankName);
        }
        public BankAccount()
        {
            AccountNumber = nextAccountNumber++;
            HolderName = "Dilshad";
            AccountType = "Savings";
            Balance = 0.0;
        }
        public BankAccount(string name, string type, double initialDeposit)
        {
            AccountNumber = nextAccountNumber++;
            HolderName = name;
            AccountType = type;
            Balance = initialDeposit;
        }
        public BankAccount(BankAccount existingAccount)
        {
            AccountNumber = nextAccountNumber++;
            HolderName = existingAccount.HolderName + " (Joint)";
            AccountType = existingAccount.AccountType;
            Balance = existingAccount.Balance / 2;
        }
        private BankAccount(bool testMode)
        {
            AccountNumber = 9999;
            HolderName = "Test Account";
            AccountType = "Testing";
            Balance = 0;
        }
        public static BankAccount CreateTestAccount()
        {
            return new BankAccount(true);
        }
        public void Display()
        {
            Console.WriteLine($"\nBank: {BankName}");
            Console.WriteLine($"Account No: {AccountNumber}");
            Console.WriteLine($"Holder Name: {HolderName}");
            Console.WriteLine($"Type: {AccountType}");
            Console.WriteLine($"Balance: Rs.{Balance}");
        }
        public static void Main()
        {
            Console.WriteLine("=== Default Account ===");
            BankAccount a1 = new BankAccount();
            a1.Display();

            Console.WriteLine("\n=== Parameterized Account ===");
            BankAccount a2 = new BankAccount("Dilshad Alam", "Current", 5000);
            a2.Display();

            Console.WriteLine("\n=== Joint Account (Copy Constructor) ===");
            BankAccount a3 = new BankAccount(a2);
            a3.Display();

            Console.WriteLine("\n=== Test Account (Private Constructor via Factory) ===");
            BankAccount test = BankAccount.CreateTestAccount();
            test.Display();
        }
    }
}