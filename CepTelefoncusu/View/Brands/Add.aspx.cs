using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CepTelefoncusu.Classes;

namespace CepTelefoncusu.Brands
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkEkle_Click(object sender, EventArgs e)
        {
            Brand b = new Brand();
            b.BrandText = txtBrandName.Text;
            b.Insert();
            Response.Redirect("List.aspx");
        }
    }
}