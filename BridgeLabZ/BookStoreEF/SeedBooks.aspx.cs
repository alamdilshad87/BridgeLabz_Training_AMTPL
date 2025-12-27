using BookStoreEF.Data;
using BookStoreEF.Models;
using System;
using System.Linq;

namespace BookStoreEF
{
    public partial class SeedBooks : System.Web.UI.Page
    {
        protected void btnSeed_Click(object sender, EventArgs e)
        {
            using (var db = new BookStoreContext())
            {
                if (!db.Books.Any())
                {
                    db.Books.Add(new Book
                    {
                        Title = "C# Basics",
                        Author = "MS",
                        Price = 499
                    });

                    db.Books.Add(new Book
                    {
                        Title = "ASP.NET",
                        Author = "Microsoft",
                        Price = 699
                    });

                    db.SaveChanges();
                    lblMsg.Text = "Books added successfully!";
                }
                else
                {
                    lblMsg.Text = "Books already exist!";
                }
            }
        }
    }
}
