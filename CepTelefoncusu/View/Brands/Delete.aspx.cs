using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.Brands
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["Id"].ToString());

            Session["Id"] = Id;
            Brand b = new Brand(Id);
            lblBrand.Text = b.BrandText;

        }

        protected void lnkEvet_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Session["Id"].ToString());

            Brand b = new Brand(Id);
            b.Delete();
           
            Response.Redirect("List.aspx");

        }
    }
}