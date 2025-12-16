using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.File_IO
{
    internal class ReadFile
    {
        public static void Main()
        {
            string path = @"C:\Users\bruh9\Downloads\MeditechRepo\BridgeLabz\alamdilshad87\BridgeLabz_Training_AMTPL\BridgeLabZ\BridgeLabZ\File_IO\data.txt";
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

        }
    }
}