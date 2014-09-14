using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View.Brands
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // Sakla butonuna basılıp gelinmiş
            }
            else
            {
                // Sayfa yüklenmiş.
                int Id = int.Parse(Request.QueryString["Id"].ToString());
                Session["Id"] = Id;
                Brand b = new Brand(Id);
                txtBrandName.Text = b.BrandText;
            }
        }

        protected void lnkSakla_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Session["Id"].ToString());
            String txtYeniMarka = txtBrandName.Text;
            Brand b = new Brand(Id);
            b.BrandText = txtYeniMarka;
            b.Save();
            Response.Redirect("List.aspx");
        }
    }
}