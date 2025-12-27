using System;
using System.Linq;
using BookStoreEF.Data;
using BookStoreEF.Models;

namespace BookStoreEF
{
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadCart();
            }
        }

        private void LoadCart()
        {
            int userId = (int)Session["UserId"];

            using (var db = new BookStoreContext())
            {
                var cartItems = db.Carts
                    .Where(c => c.UserId == userId)
                    .Select(c => new
                    {
                        c.CartId,
                        Title = c.Book.Title,
                        Price = c.Book.Price,
                        c.Quantity,
                        Total = c.Book.Price * c.Quantity
                    })
                    .ToList();

                gvCart.DataSource = cartItems;
                gvCart.DataBind();

                decimal grandTotal = cartItems.Sum(x => x.Total);
                lblTotal.Text = "Grand Total: ₹ " + grandTotal;
            }
        }

        protected void PlaceOrder_Click(object sender, EventArgs e)
        {
            int userId = (int)Session["UserId"];

            using (var db = new BookStoreContext())
            {
                var cartItems = db.Carts
                    .Where(c => c.UserId == userId)
                    .ToList();

                if (!cartItems.Any())
                    return;

                decimal totalAmount = cartItems.Sum(c => c.Book.Price * c.Quantity);

                // Create Order
                var order = new Order
                {
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    TotalAmount = (int)totalAmount
                };

                db.Orders.Add(order);

                // Clear Cart
                db.Carts.RemoveRange(cartItems);

                db.SaveChanges();
            }

            Response.Redirect("Orders.aspx");
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Books.aspx");
        }
    }
}
