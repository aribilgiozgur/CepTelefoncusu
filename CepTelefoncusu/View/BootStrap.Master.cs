using CepTelefoncusu.Application;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View
{
    public partial class BootStrap : System.Web.UI.MasterPage
    {
        public bool UserLoggedIn = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null) {
                UserLoggedIn = true;

                int userId = int.Parse(Session["UserId"].ToString());

                // TODO: Fonksiyonlanacak! String GetRealName(int userId)
                lblName.Text = CepUser.GetRealName(userId);

            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx");
        }
    }
}