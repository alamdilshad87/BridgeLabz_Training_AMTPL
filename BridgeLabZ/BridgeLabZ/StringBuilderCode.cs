using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    internal class StringBuilderCode
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder("C# is");
            sb.Append(" fast");
            sb.Append(", flexible");
            sb.Append(", and powerful!");
            sb.Insert(6, " very");
            sb.Replace("powerful", "awesome");
            Console.WriteLine("Final String: " + sb.ToString());
            Console.WriteLine("Length: " + sb.Length);
            Console.WriteLine("Capacity: " + sb.Capacity);
        }
    }
}