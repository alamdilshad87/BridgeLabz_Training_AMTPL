using System;
using System.Linq;
using BookStoreEF.Data;

namespace BookStoreEF
{
    public partial class WishlistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
                Response.Redirect("Login.aspx");

            if (!IsPostBack)
                LoadWishlist();
        }

        private void LoadWishlist()
        {
            int userId = (int)Session["UserId"];

            using (var db = new BookStoreContext())
            {
                var data = db.Wishlists
                    .Where(w => w.UserId == userId)
                    .Select(w => new
                    {
                        w.WishlistId,
                        Title = w.Book.Title,
                        Author = w.Book.Author,
                        Price = w.Book.Price
                    })
                    .ToList();

                gvWishlist.DataSource = data;
                gvWishlist.DataBind();
            }
        }

        protected void gvWishlist_RowCommand(object sender,
            System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int wishlistId = Convert.ToInt32(
                    gvWishlist.DataKeys[index].Value);

                using (var db = new BookStoreContext())
                {
                    var item = db.Wishlists.Find(wishlistId);
                    db.Wishlists.Remove(item);
                    db.SaveChanges();
                }

                LoadWishlist();
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Books.aspx");
        }
    }
}
