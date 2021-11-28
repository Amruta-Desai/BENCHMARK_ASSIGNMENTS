using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "")
            {
                lblerr.ForeColor = Color.Red;
                lblerr.Text = "Please enter login name";
            }
            else if (txtPass.Text == "")
            {
                lblerrpass.ForeColor = Color.Red;
                lblerrpass.Text = " Please enter a password";
            }
            else if(txtLogin.Text != "" && txtPass.Text!= "")
            {
                string login = txtLogin.Text;
                string pass = txtPass.Text;
                DAL d = new DAL();
                if (d.Login(login,pass))
                {
                    Response.Redirect("FirstPage.aspx");
                }
                else
                {
                    lblerr.Text = "";
                    lblerrpass.Text = "";
                    lblerr2.ForeColor = Color.Red;
                    lblerr2.Text = "Invalid Username or Password.Try again";
                }
            }

        }
    }
}