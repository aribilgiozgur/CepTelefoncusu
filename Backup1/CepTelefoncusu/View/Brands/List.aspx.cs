using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CepTelefoncusu.Classes;

namespace CepTelefoncusu.Brands
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            List<Brand> allbrand = brand.GetAll();
            rptBrand.DataSource = allbrand;
            rptBrand.DataBind();
        }
    }
}