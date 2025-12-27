using System;
using System.Linq;
using BookStoreEF.Data;

namespace BookStoreEF
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadOrders();
            }
        }

        private void LoadOrders()
        {
            int userId = (int)Session["UserId"];

            using (var db = new BookStoreContext())
            {
                var orders = db.Orders
                    .Where(o => o.UserId == userId)
                    .OrderByDescending(o => o.OrderDate)
                    .Select(o => new
                    {
                        o.OrderId,
                        o.OrderDate,
                        o.TotalAmount
                    })
                    .ToList();

                gvOrders.DataSource = orders;
                gvOrders.DataBind();
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Books.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}
