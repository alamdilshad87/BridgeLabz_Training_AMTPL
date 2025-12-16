using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.File_IO
{
    internal class FileOperations
    {
        public static void Main()
        {
            Console.WriteLine("Creating a txt file");
            using (StreamWriter writer = File.CreateText("MyFile.txt"))
            {
                writer.WriteLine("Hello Everyone, This is First Line");
                writer.WriteLine("Myself Dilshad Alam. This is Second Line");
            }

            Console.WriteLine("\nReading txt file");
            using (StreamReader reader=new StreamReader("MyFile.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }

            Console.WriteLine("\nAppending 3rd Line");
            using (StreamWriter writer=File.AppendText("MyFile.txt"))
            {
                writer.WriteLine("Appending Complete. Added 3rd Line");
            }

            Console.WriteLine("\nReading All Lines");
            using (StreamReader reader = new StreamReader("MyFile.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }

            Console.WriteLine("\nDeleting a File");
            string path = "MyFile.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
            else
                Console.WriteLine("File Doesn't Exists");
        }
    }
}