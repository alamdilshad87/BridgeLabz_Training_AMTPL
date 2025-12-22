using System;
using Microsoft.Data.SqlClient;

namespace BridgeLabZ.SchoolDB
{
    internal class School
    {
        static void Main()
        {
            string connectionString =
                "Server=DILSHAD\\SQLEXPRESS;" +
                "Database=SchoolDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Connected to DB");

                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO Students (Name, Age, City) VALUES ('Dilshad', 21, 'Dhanbad')",
                    con);
                insertCmd.ExecuteNonQuery();
                Console.WriteLine("Inserted");

                SqlCommand selectCmd = new SqlCommand(
                    "SELECT * FROM Students",
                    con);
                SqlDataReader reader = selectCmd.ExecuteReader();

                Console.WriteLine("Students:");
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}, City: {reader["City"]}");
                }
                reader.Close();

                SqlCommand updateCmd = new SqlCommand(
                    "UPDATE Students SET City='Ranchi' WHERE Name='Dilshad'",
                    con);
                updateCmd.ExecuteNonQuery();
                Console.WriteLine("Updated");

                //SqlCommand deleteCmd = new SqlCommand(
                //    "DELETE FROM Students WHERE Name='Dilshad'",
                //    con);
                //deleteCmd.ExecuteNonQuery();
                //Console.WriteLine("Deleted");
            }

            Console.ReadKey();
        }
    }
}
