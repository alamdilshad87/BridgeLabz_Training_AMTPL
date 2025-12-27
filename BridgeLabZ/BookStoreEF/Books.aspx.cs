using System;
using System.Linq;
using BookStoreEF.Data;
using BookStoreEF.Models;

namespace BookStoreEF
{
    public partial class Books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
                Response.Redirect("Login.aspx");

            if (!IsPostBack)
            {
                using (var db = new BookStoreContext())
                {
                    gvBooks.DataSource = db.Books.ToList();
                    gvBooks.DataBind();
                }
            }
        }

        protected void gvBooks_RowCommand(object sender,
            System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int bookId = Convert.ToInt32(gvBooks.DataKeys[index].Value);
            int userId = Convert.ToInt32(Session["UserId"]);

            using (var db = new BookStoreContext())
            {
                // ADD TO CART
                if (e.CommandName == "AddToCart")
                {
                    var cartItem = db.Carts
                        .FirstOrDefault(c => c.UserId == userId && c.BookId == bookId);

                    if (cartItem != null)
                        cartItem.Quantity += 1;
                    else
                        db.Carts.Add(new Cart
                        {
                            UserId = userId,
                            BookId = bookId,
                            Quantity = 1
                        });
                }

                // ADD TO WISHLIST
                if (e.CommandName == "AddToWishlist")
                {
                    var wish = db.Wishlists
                        .FirstOrDefault(w => w.UserId == userId && w.BookId == bookId);

                    if (wish == null)
                    {
                        db.Wishlists.Add(new Wishlist
                        {
                            UserId = userId,
                            BookId = bookId
                        });
                    }
                }

                db.SaveChanges();
            }
        }

        protected void ViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }

        protected void ViewWishlist_Click(object sender, EventArgs e)
        {
            Response.Redirect("Wishlist.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}
