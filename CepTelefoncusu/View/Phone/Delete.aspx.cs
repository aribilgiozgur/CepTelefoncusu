using CepTelefoncusu.Domain.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View.Phone
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["Id"].ToString());

            Session["Id"] = Id;
            CellPhone c = new CellPhone(Id);
            lblTelephone.Text = c.BrandText + " " + c.ModelText;
        }
        protected void lnkEvet_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Session["Id"].ToString());

            CellPhone c = new CellPhone(Id);
            c.Delete();

            Response.Redirect("List.aspx");

        }
    }
}