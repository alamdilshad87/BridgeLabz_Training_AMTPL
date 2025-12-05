using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.ExceptionHandling
{
    internal class DivideByZero
    {
        static void Main()
        {
            try
            {
                int a = 10, b = 0;
                int result = a / b;
                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero. " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block always executes.");
            }
        }
    }
}