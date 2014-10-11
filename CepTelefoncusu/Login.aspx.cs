using CepTelefoncusu.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null) {
                Response.Redirect("index.aspx");
            }
        }

        protected void lnkSubmit_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            String passWord = txtPassword.Text;


            int userId = CepUser.CheckUser(userName, passWord);
            if (userId != -1)
            {
                Session["UserId"] = userId;
                Response.Redirect("index.aspx");
            }
            else {
                lblError.Text = "Wrong username or password, please try again";
                lblError.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            String passWord = txtPassword.Text;


            int userId = CepUser.CheckUser(userName, passWord);
            if (userId != -1)
            {
                Session["UserId"] = userId;
                Response.Redirect("index.aspx");
            }
            else
            {
                lblError.Text = "Wrong username or password, please try again";
                lblError.Visible = true;
            }
        }
    }
}