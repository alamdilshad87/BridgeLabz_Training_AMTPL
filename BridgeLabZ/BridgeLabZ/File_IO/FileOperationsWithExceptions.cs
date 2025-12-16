using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.File_IO
{
    internal class FileOperationsWithExceptions
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Creating File\n");
                using (StreamWriter writer = File.CreateText("ExceptionFile.txt"))
                {
                    writer.WriteLine("This is the First Line of Exception File.");
                    writer.WriteLine("This is now the Second Line of Exception File.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }

            try
            {
                Console.WriteLine("Reading Content from File\n");
                using (StreamReader reader = new StreamReader("ExceptionFile.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        Console.WriteLine(line);
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                Console.WriteLine("\nAppending In File\n");
                using(StreamWriter writer = File.AppendText("ExceptionFile.txt"))
                {
                    writer.WriteLine("This is now the 3rd line that is being appended.");
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                Console.WriteLine("Reading Content after appending Content\n");
                using (StreamReader reader = new StreamReader("ExceptionFile.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                Console.WriteLine("\nDeleting File\n");
                string path = "ExceptionFile.txt";
                if(File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("File Deleted");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            try
            {
                string path = "ExtensionFile.txt";
                if (File.Exists(path))
                {
                    Console.WriteLine("\nFile Exists");
                }
                else
                    Console.WriteLine("\nFile Doesn't Exists");
            }

            finally
            {
                Console.WriteLine("\nFile Operation Completed");
            }
        }
    }
}