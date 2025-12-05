using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.ExceptionHandling
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class CustomException
    {
        static void Main()
        {
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                    throw new InvalidAgeException("Age must be 18 or above.");

                Console.WriteLine("Access Granted!");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
        }
    }
}
