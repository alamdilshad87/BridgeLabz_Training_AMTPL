using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Lambdas
{
    internal class LambdaWithLists
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNo = list.FindAll(x => x % 2 == 0);
            foreach (var i in evenNo)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}