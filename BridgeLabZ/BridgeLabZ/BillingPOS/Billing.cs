using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.BillingPOS
{
    public class Billing
    {
        class Program
        {
            static string connectionString =
                "Server=DILSHAD\\SQLEXPRESS;" +
                "Database=Billing;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;";

            static void Main()
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand billCmd = new SqlCommand(
                        "INSERT INTO Bills (BillDate, TotalAmount) OUTPUT INSERTED.BillId VALUES (GETDATE(), @Total)",
                        conn, transaction);

                    billCmd.Parameters.AddWithValue("@Total", 120);
                    int billId = (int)billCmd.ExecuteScalar();

                    var items = new[]
                    {
                    new { ProductId = 101, Qty = 2 },
                    new { ProductId = 102, Qty = 2 }
                };

                    foreach (var item in items)
                    {
                        SqlCommand stockCmd = new SqlCommand(
                            "SELECT Stock, Price FROM Inventory WHERE ProductId=@Pid",
                            conn, transaction);

                        stockCmd.Parameters.AddWithValue("@Pid", item.ProductId);

                        SqlDataReader reader = stockCmd.ExecuteReader();

                        if (!reader.Read())
                            throw new Exception("Product not found");

                        int stock = (int)reader["Stock"];
                        decimal price = (decimal)reader["Price"];
                        reader.Close();

                        if (stock < item.Qty)
                            throw new Exception("Insufficient stock for product " + item.ProductId);

                        SqlCommand itemCmd = new SqlCommand(
                            "INSERT INTO BillItems (BillId, ProductId, Quantity, Price) VALUES (@BillId,@Pid,@Qty,@Price)",
                            conn, transaction);

                        itemCmd.Parameters.AddWithValue("@BillId", billId);
                        itemCmd.Parameters.AddWithValue("@Pid", item.ProductId);
                        itemCmd.Parameters.AddWithValue("@Qty", item.Qty);
                        itemCmd.Parameters.AddWithValue("@Price", price);

                        itemCmd.ExecuteNonQuery();

                        SqlCommand updateCmd = new SqlCommand(
                            "UPDATE Inventory SET Stock = Stock - @Qty WHERE ProductId=@Pid",
                            conn, transaction);

                        updateCmd.Parameters.AddWithValue("@Qty", item.Qty);
                        updateCmd.Parameters.AddWithValue("@Pid", item.ProductId);

                        updateCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    Console.WriteLine("Bill Generated Successfully");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction Failed: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}