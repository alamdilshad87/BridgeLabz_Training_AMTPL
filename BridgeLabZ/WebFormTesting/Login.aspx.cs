using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTesting
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lblmsg.Text = "";
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserTxt.Text;
            string pass = PasswordTxt.Text;

            if (username == "admin" && pass == "1234")
            {
                Session["User"] = username;
                Response.Redirect("Default.aspx");
            }
            else
                lblmsg.Text = "Invalid username or password";
        }
    }
}