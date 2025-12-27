using BookStoreEF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreEF.Models;
using BookStoreEF.Helpers;


namespace BookStoreEF
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db=new BookStoreContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Email == txtEmail.Text);
                    if(user==null)
                    {
                        lblMessage.Text = "Invalid Email or Password";
                        return;
                    }
                    bool isValid = PasswordHelper.Verify(txtPassword.Text, user.PasswordHash, user.PasswordSalt);
                    if(!isValid)
                    {
                        lblMessage.Text = "Invalid Email or Password";
                        return;
                    }

                    Session["UserId"] = user.UserId;
                    Session["UserName"] = user.FullName;
                    Response.Redirect("Books.aspx");
                }
            }
            catch(Exception ex)
            {
                lblMessage.Text = "Error:" + ex.Message;
            }
        }
    }
}