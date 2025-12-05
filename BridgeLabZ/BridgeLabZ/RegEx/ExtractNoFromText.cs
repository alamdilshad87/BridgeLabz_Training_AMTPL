using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabZ.RegEx
{
    internal class ExtractNoFromText
    {
        static void Main()
        {
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, @"\d+");

            foreach (Match m in matches)
                Console.WriteLine(m.Value);
        }
    }
}