using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Question
{
    internal class FetchDataReader
    {
        public static void Main()
        {
            string connectionString =
                "Server=DILSHAD\\SQLEXPRESS;" +
                "Database=SchoolDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("New Connection Made");

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
            }
        }
    }
}
