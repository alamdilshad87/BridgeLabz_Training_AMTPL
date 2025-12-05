using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.NonGenericCollections._1_ArrayList
{
    public class ArrayList_Functions
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Console.WriteLine(" Add() ");
            list.Add(10);
            list.Add(20);
            list.Add(30);
            Print(list);

            Console.WriteLine("\n AddRange() ");
            list.AddRange(new int[] { 40, 50, 60 });
            Print(list);

            Console.WriteLine("\n Insert() ");
            list.Insert(2, 25);
            Print(list);

            Console.WriteLine("\n InsertRange() ");
            list.InsertRange(3, new string[] { "A", "B" });
            Print(list);

            Console.WriteLine("\n Contains() ");
            Console.WriteLine("Contains 50? " + list.Contains(50));

            Console.WriteLine("\n IndexOf() ");
            Console.WriteLine("Index of 30: " + list.IndexOf(30));

            Console.WriteLine("\n Remove() ");
            list.Remove("A");
            Print(list);

            Console.WriteLine("\n RemoveAt() ");
            list.RemoveAt(0);
            Print(list);

            Console.WriteLine("\n RemoveRange() ");
            list.RemoveRange(1, 2);
            Print(list);

            Console.WriteLine("\n Sort() ");
            ArrayList numericList = new ArrayList() { 5, 2, 8, 1, 9 };
            numericList.Sort();
            Print(numericList);

            Console.WriteLine("\n Reverse() ");
            numericList.Reverse();
            Print(numericList);

            Console.WriteLine("\n Count ");
            Console.WriteLine("Count: " + list.Count);

            Console.WriteLine("\n Capacity ");
            Console.WriteLine("Capacity: " + list.Capacity);

            Console.WriteLine("\n Clear() ");
            list.Clear();
            Console.WriteLine("List cleared. Count = " + list.Count);
        }

        public static void Print(ArrayList arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}