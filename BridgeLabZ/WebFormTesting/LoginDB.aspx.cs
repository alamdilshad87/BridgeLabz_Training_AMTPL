using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            string user = UserNameTxt.Text;
            string pass = PasswordTxt.Text;

            using(SqlConnection conn=new SqlConnection(constr))
            {
                string query = "Select count(*) from dbo.Table where user=@u and password=@p";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Parameter binding (prevents SQL Injection)
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                conn.Open(); // ACTUAL DB CONNECTION HAPPENS HERE

                int result = (int)cmd.ExecuteScalar();

                if (result == 1)
                {
                    Session["User"] = user;
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    lblmsg.Text = "Invalid username or password";
                }
            }
        }
    }
}