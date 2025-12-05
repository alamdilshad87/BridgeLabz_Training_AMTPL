using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabZ.RegEx
{
    internal class ValidateMobile
    {
        static void Main()
        {
            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();
            string pattern = @"^[6-9]\d{9}$";
            bool isValid = Regex.IsMatch(mobile, pattern);

            if (isValid)
            {
                Console.WriteLine("Valid Mobile Number!");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number. Please enter a valid 10-digit number.");
            }

            Console.ReadLine();
        }
    }
}