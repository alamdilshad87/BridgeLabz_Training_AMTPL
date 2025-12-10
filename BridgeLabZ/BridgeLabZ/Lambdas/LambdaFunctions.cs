using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Lambdas
{
    internal class LambdaFunctions
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Original List:");
            list.ForEach(x => Console.Write(x + " "));

            var even = list.FindAll(x => x % 2 == 0);
            Console.WriteLine("\nEven Numbers:");
            even.ForEach(x=>Console.Write(x+" "));

            var firstGreater4 = list.Find(x => x > 4);
            Console.WriteLine("\nFirst Number > 4: " + firstGreater4);

            bool hasEven = list.Exists(x => x % 2 == 0);
            Console.WriteLine("Has Even Number? " + hasEven);

            var squares = list.Select(x => x * x);
            Console.WriteLine("Squares:");
            foreach (var s in squares) 
                Console.Write(s + " ");

            var greaterThan3 = list.Where(x => x > 3);
            Console.WriteLine("\nNumbers > 3:");
            foreach (var n in greaterThan3) 
                Console.Write(n + " ");

            bool anyGreater5 = list.Any(x => x > 5);
            Console.WriteLine("\nAny > 5? " + anyGreater5);
           
            bool allLess10 = list.All(x => x < 10);
            Console.WriteLine("\nAll < 10? " + allLess10);

            list.Sort((a, b) => a.CompareTo(b));
            Console.WriteLine("\nSorted Ascending:");
            list.ForEach(x => Console.Write(x + " "));

            var descList = new List<int>(list);
            descList.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("\nSorted Descending:");
            descList.ForEach(x => Console.Write(x + " "));

            int countGreater3 = list.Count(x => x > 3);
            Console.WriteLine("\nCount of numbers > 3: " + countGreater3);
            
            Console.ReadLine();
        }
    }
}