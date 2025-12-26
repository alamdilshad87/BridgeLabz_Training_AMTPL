using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.BillingPOS
{
    internal class BillingAdv
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
                Console.WriteLine("=== POS Billing System ===");

                Console.Write("Enter number of items: ");
                int itemCount = int.Parse(Console.ReadLine());

                List<(int ProductId, int Qty)> items = new List<(int, int)>();

                for (int i = 0; i < itemCount; i++)
                {
                    Console.Write($"Enter Product ID for item {i + 1}: ");
                    int pid = int.Parse(Console.ReadLine());

                    Console.Write($"Enter Quantity for item {i + 1}: ");
                    int qty = int.Parse(Console.ReadLine());

                    items.Add((pid, qty));
                }

                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    decimal totalAmount = 0;

                    SqlCommand billCmd = new SqlCommand(
                        "INSERT INTO Bills (BillDate, TotalAmount) OUTPUT INSERTED.BillId VALUES (GETDATE(), 0)",
                        conn, transaction);

                    int billId = (int)billCmd.ExecuteScalar();

                    foreach (var item in items)
                    {
                        // Check stock & price
                        SqlCommand stockCmd = new SqlCommand(
                            "SELECT Stock, Price FROM Inventory WHERE ProductId=@Pid",
                            conn, transaction);

                        stockCmd.Parameters.AddWithValue("@Pid", item.ProductId);

                        using SqlDataReader reader = stockCmd.ExecuteReader();

                        if (!reader.Read())
                            throw new Exception($"Product {item.ProductId} not found");

                        int stock = (int)reader["Stock"];
                        decimal price = (decimal)reader["Price"];
                        reader.Close();

                        if (stock < item.Qty)
                            throw new Exception($"Insufficient stock for Product {item.ProductId}");

                        decimal itemTotal = price * item.Qty;
                        totalAmount += itemTotal;

                        // Insert BillItem
                        SqlCommand itemCmd = new SqlCommand(
                            "INSERT INTO BillItems (BillId, ProductId, Quantity, Price) VALUES (@BillId,@Pid,@Qty,@Price)",
                            conn, transaction);

                        itemCmd.Parameters.AddWithValue("@BillId", billId);
                        itemCmd.Parameters.AddWithValue("@Pid", item.ProductId);
                        itemCmd.Parameters.AddWithValue("@Qty", item.Qty);
                        itemCmd.Parameters.AddWithValue("@Price", price);

                        itemCmd.ExecuteNonQuery();

                        // Update Inventory
                        SqlCommand updateCmd = new SqlCommand(
                            "UPDATE Inventory SET Stock = Stock - @Qty WHERE ProductId=@Pid",
                            conn, transaction);

                        updateCmd.Parameters.AddWithValue("@Qty", item.Qty);
                        updateCmd.Parameters.AddWithValue("@Pid", item.ProductId);

                        updateCmd.ExecuteNonQuery();
                    }

                    SqlCommand updateBill = new SqlCommand(
                        "UPDATE Bills SET TotalAmount=@Total WHERE BillId=@BillId",
                        conn, transaction);

                    updateBill.Parameters.AddWithValue("@Total", totalAmount);
                    updateBill.Parameters.AddWithValue("@BillId", billId);
                    updateBill.ExecuteNonQuery();

                    transaction.Commit();
                    Console.WriteLine($"Bill Generated Successfully! Bill ID: {billId}");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction Failed ❌");
                    Console.WriteLine("Reason: " + ex.Message);
                }
            }
        }
    }
}