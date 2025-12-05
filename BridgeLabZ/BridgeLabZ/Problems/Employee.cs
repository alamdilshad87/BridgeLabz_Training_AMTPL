using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Problems
{
    internal class Employee
    {
        static void Main()
        {
            SortedDictionary<int, string> emp = new SortedDictionary<int, string>();

            emp.Add(102, "Om");
            emp.Add(101, "Prajan");
            emp.Add(105, "Adarsh");

            foreach (var e in emp)
                Console.WriteLine(e.Key + " : " + e.Value);
        }
    }
}