using BookStoreEF.Data;
using BookStoreEF.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreEF.Models;

namespace BookStoreEF
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] hash, salt;
                PasswordHelper.CreateHash(txtPassword.Text, out hash, out salt);

                using (var db = new BookStoreContext())
                {
                    var existingUser = db.Users
                        .FirstOrDefault(u => u.Email == txtEmail.Text);

                    if (existingUser != null)
                    {
                        lblMessage.Text = "Email already registered";
                        return;
                    }

                    var user = new User
                    {
                        FullName = txtName.Text,
                        Email = txtEmail.Text,              // ✅ FIXED
                        PasswordHash = hash,
                        PasswordSalt = salt,
                        CreatedAt = DateTime.Now            // ✅ FIXED
                    };

                    db.Users.Add(user);
                    db.SaveChanges();
                }

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Registration successful";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}