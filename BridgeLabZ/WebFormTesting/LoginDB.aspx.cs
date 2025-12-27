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
        string cs = System.Configuration.ConfigurationManager
                        .ConnectionStrings["MyDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                lblmsg.Text = "";
        }
        protected void Register_Click(object sender, EventArgs e)
        {
            string user = UserNameTxt.Text;
            string pass = PasswordTxt.Text;

            string hash, salt;
            PasswordHelper.CreatePasswordHash(pass, out hash, out salt);

            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query =
                "INSERT INTO dbo.TableInfo ([user], PasswordHash, PasswordSalt) " +
                "VALUES (@u, @h, @s)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@h", hash);
                cmd.Parameters.AddWithValue("@s", salt);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        protected void Login_Click(object sender, EventArgs e)
        {
            

            string user = UserNameTxt.Text;
            string pass = PasswordTxt.Text;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query =
                "SELECT PasswordHash, PasswordSalt FROM dbo.TableInfo WHERE [user]=@u";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", user);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string hash = reader["PasswordHash"].ToString();
                    string salt = reader["PasswordSalt"].ToString();

                    bool valid =
                        PasswordHelper.VerifyPassword(pass, hash, salt);

                    if (valid)
                    {
                        Session["User"] = user;
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        lblmsg.Text = "Invalid username or password";
                    }
                }
                else
                {
                    lblmsg.Text = "Invalid username or password";
                }
            }
        }
    }
}