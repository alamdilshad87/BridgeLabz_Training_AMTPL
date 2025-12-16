using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.LINQ
{
    internal class SimpleLINQ
    {
        public static void Main()
        {
            string[] names = { "Dilshad", "Gourav", "Adarsh", "Pranav" };
            var myLinqQuery = from name in names
                              where name.Contains('h')
                              select name;
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");
        }
    }
}
