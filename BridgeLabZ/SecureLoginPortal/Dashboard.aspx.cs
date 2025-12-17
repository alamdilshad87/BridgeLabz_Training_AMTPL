using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SecureLoginPortal
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
                Response.Redirect("Default.aspx");

            lblWelcome.Text = "Welcome " + Session["User"];
        }
    }
}
