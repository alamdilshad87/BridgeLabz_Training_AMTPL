using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    internal class StringManipulation
    {
        static void Main()
        {
            string sentence = "  C# is a Powerful Language  ";
            Console.WriteLine("Original: '" + sentence + "'");

            string trimmed = sentence.Trim();
            string upper = trimmed.ToUpper();
            string replaced = upper.Replace("POWERFUL", "AMAZING");
            string substring = replaced.Substring(0, 10);

            Console.WriteLine("Trimmed: '" + trimmed + "'");
            Console.WriteLine("Uppercase: '" + upper + "'");
            Console.WriteLine("Replaced: '" + replaced + "'");
            Console.WriteLine("Substring: '" + substring + "'");
        }
    }
}
