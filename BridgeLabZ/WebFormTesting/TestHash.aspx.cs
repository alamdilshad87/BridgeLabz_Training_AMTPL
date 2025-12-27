using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTesting
{
    public partial class TestHash_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string hash, salt;

            PasswordHelper.CreatePasswordHash("09876", out hash, out salt);

            Response.Write("HASH: " + hash + "<br/>");
            Response.Write("SALT: " + salt);
        }

    }
}