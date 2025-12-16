using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.File_IO
{
    internal class CreateFile
    {
        public static void Main()
        {
            using (StreamWriter writer = File.CreateText("Create_data.txt"))
            {
                writer.WriteLine("This is the first line.");
                writer.WriteLine("This is the second line.");
            }
            using(StreamReader reader=File.OpenText("Create_data.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }
        }
    }
}
