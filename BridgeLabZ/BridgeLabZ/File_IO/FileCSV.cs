using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.File_IO
{
    internal class FileCSV
    {
        public static void Main()
        {
            using (StreamWriter writer = new StreamWriter("Students.csv"))
            {
                writer.WriteLine("Id, Name, Age");
                writer.WriteLine("1, Dilshad, 21");
                writer.WriteLine("2, Om, 22");
                writer.WriteLine("3, Gaurav, 20");
            }
            Console.WriteLine("CSV file created");

            using (StreamReader reader = new StreamReader("Students.csv"))
            {
                string line;
                while((line=reader.ReadLine())!=null)
                {
                    string[] data = line.Split(",");
                    Console.WriteLine($"Id: {data[0]} , Name: {data[1]} , Age: {data[2]}");
                }
            }
        }
    }
}