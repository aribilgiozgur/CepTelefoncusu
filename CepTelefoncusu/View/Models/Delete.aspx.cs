using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View.Models
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["Id"]);
            Session["Id"] = Id;
            Model m = new Model(Id);
            String uyari = Brand.GetBrandText(m.BrandId) + " - " + m.ModelText;
            lblModel.Text = uyari;
        }

        protected void lnkEvet_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Session["Id"].ToString());
            Model m = new Model(Id);
            m.Delete();
            Response.Redirect("List.aspx");

        }
    }
}