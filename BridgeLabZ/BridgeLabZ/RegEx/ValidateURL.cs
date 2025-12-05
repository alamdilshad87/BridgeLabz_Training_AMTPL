using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabZ.RegEx
{
    internal class ValidateURl
    {
        static void Main()
        {
            string url = Console.ReadLine();
            string pattern = @"^(https?://)?([\w\-]+\.)+[\w]{2,6}(/.*)?$";
            bool isValid = Regex.IsMatch(url, pattern);
            if (isValid)
            {
                Console.WriteLine("Valid URL");
            }
            else
            {
                Console.WriteLine("Invalid URL");
            }
        }

    }
}