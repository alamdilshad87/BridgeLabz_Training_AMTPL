using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Problems
{
    internal class AutoComplete_Dictionary
    {
        static void Main()
        {
            Dictionary<int, string> words = new Dictionary<int, string>()
            {
                {1,"apple"}, {2,"application"}, {3,"banana"}, {4,"appetizer"}
            };
            string prefix = Console.ReadLine();
            foreach (var w in words.Values)
                if (w.StartsWith(prefix))
                    Console.WriteLine(w);
        }
    }
}