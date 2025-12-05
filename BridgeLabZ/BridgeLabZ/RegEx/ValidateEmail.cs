using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabZ.RegEx
{
    internal class ValidateEmail
    {
        static void Main()
        {
            string email = Console.ReadLine();
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, pattern))
                Console.WriteLine("Valid Email");
            else
                Console.WriteLine("Invalid Email");
        }
    }
}
