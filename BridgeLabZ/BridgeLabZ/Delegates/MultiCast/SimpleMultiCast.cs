using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Delegates.MultiCast
{
    internal class SimpleMultiCast
    {
        public delegate void Notify();
        public static void A() => Console.WriteLine("Method A Executed");
        public static void B() => Console.WriteLine("Method B Executed");
        public static void C() => Console.WriteLine("Method C Executed");
        public static void Main()
        {
            Notify del = A;
            del += B;
            del += C;

            Console.WriteLine("Multicast Execution:");
            del();

            del -= B;

            Console.WriteLine("\nAfter Removing B:");
            del();
        }
    }
}