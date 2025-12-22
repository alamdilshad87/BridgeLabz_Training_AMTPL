using System;
using Microsoft.Data.SqlClient;

namespace BridgeLabZ.SchoolDB
{
    internal class SchoolAdv
    {
        static string connectionString =
            "Server=DILSHAD\\SQLEXPRESS;" +
            "Database=SchoolDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";

        static void Main()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    Console.WriteLine("Connected to DB");

                    while (true)
                    {
                        Console.WriteLine("\n1. Insert");
                        Console.WriteLine("2. View All");
                        Console.WriteLine("3. Update by Name");
                        Console.WriteLine("4. Delete by Name");
                        Console.WriteLine("5. Exit");
                        Console.Write("Enter choice: ");

                        try
                        {
                            int choice = int.Parse(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    InsertStudent(con);
                                    break;

                                case 2:
                                    ViewStudents(con);
                                    break;

                                case 3:
                                    UpdateByName(con);
                                    break;

                                case 4:
                                    DeleteByName(con);
                                    break;

                                case 5:
                                    Console.WriteLine("Exiting...");
                                    return;

                                default:
                                    Console.WriteLine("Invalid choice");
                                    break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error");
                Console.WriteLine(ex.Message);
            }
        }


        static void InsertStudent(SqlConnection con)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            SqlCommand cmd = new SqlCommand(
                $"INSERT INTO Students (Name, Age, City) VALUES ('{name}', {age}, '{city}')",
                con);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Record Inserted");
        }

        static void ViewStudents(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nStudents List:");
            if (!reader.HasRows)
            {
                Console.WriteLine("No records found");
            }

            while (reader.Read())
            {
                Console.WriteLine(
                    $"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}, City: {reader["City"]}");
            }
            reader.Close();
        }

        static void UpdateByName(SqlConnection con)
        {
            while (true)
            {
                Console.Write("Enter Name to Update: ");
                string name = Console.ReadLine();

                if (!RecordExists(con, name))
                {
                    Console.WriteLine("Name not found. Try again? (y/n)");
                    if (Console.ReadLine().ToLower() != "y")
                        return;
                    continue;
                }

                Console.Write("Enter New City: ");
                string city = Console.ReadLine();

                SqlCommand cmd = new SqlCommand(
                    $"UPDATE Students SET City='{city}' WHERE Name='{name}'",
                    con);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Updated");
                return;
            }
        }

        static void DeleteByName(SqlConnection con)
        {
            while (true)
            {
                Console.Write("Enter Name to Delete: ");
                string name = Console.ReadLine();

                if (!RecordExists(con, name))
                {
                    Console.WriteLine("Name not found. Try again? (y/n)");
                    if (Console.ReadLine().ToLower() != "y")
                        return;
                    continue;
                }

                SqlCommand cmd = new SqlCommand(
                    $"DELETE FROM Students WHERE Name='{name}'",
                    con);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Deleted");
                return;
            }
        }

        static bool RecordExists(SqlConnection con, string name)
        {
            SqlCommand cmd = new SqlCommand(
                $"SELECT COUNT(*) FROM Students WHERE Name='{name}'",
                con);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }
}
