using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._6_SortedSet
{
    internal class SortedSet_Functions
    {
        static void Main()
        {
            SortedSet<int> ss = new SortedSet<int>();

            ss.Add(40);
            ss.Add(10);
            ss.Add(30);
            ss.Add(20);

            Console.WriteLine("SortedSet Elements:");
            foreach (var item in ss)
                Console.WriteLine(item);

            Console.WriteLine("\nContains 20: " + ss.Contains(20));

            ss.Remove(10);

            Console.WriteLine("\nAfter Remove 10:");
            foreach (var item in ss)
                Console.WriteLine(item);

            SortedSet<int> other = new SortedSet<int>() { 20, 50, 60 };

            ss.UnionWith(other);

            Console.WriteLine("\nAfter UnionWith:");
            foreach (var item in ss)
                Console.WriteLine(item);

            ss.IntersectWith(new SortedSet<int>() { 20, 60 });

            Console.WriteLine("\nAfter IntersectWith:");
            foreach (var item in ss)
                Console.WriteLine(item);

            ss.ExceptWith(new SortedSet<int>() { 60 });

            Console.WriteLine("\nAfter ExceptWith (remove 60):");
            foreach (var item in ss)
                Console.WriteLine(item);

            ss.SymmetricExceptWith(new SortedSet<int>() { 20, 70, 80 });

            Console.WriteLine("\nAfter SymmetricExceptWith {20, 70, 80}:");
            foreach (var item in ss)
                Console.WriteLine(item);

            Console.WriteLine("\nMin: " + ss.Min);
            Console.WriteLine("Max: " + ss.Max);

            Console.WriteLine("Count: " + ss.Count);

            ss.Clear();
            Console.WriteLine("Count after Clear: " + ss.Count);
        }
    }
}
