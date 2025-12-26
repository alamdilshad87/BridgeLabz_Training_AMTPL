using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTesting
{
    public partial class LoginDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                lblmsg.Text = "";
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string user = UserNameTxt.Text;
            string pass = PasswordTxt.Text;

        }
    }
}