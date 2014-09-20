using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View.Phone
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Brand b = new Brand();

                

                drpBrandId.DataSource = b.GetAll();
                drpBrandId.DataValueField = "Id";
                drpBrandId.DataTextField = "BrandText";
                drpBrandId.DataBind();

                int brandId = int.Parse(drpBrandId.SelectedValue);
                Model m = new Model();
                drpModelId.DataSource = m.GetModels(brandId);
                drpModelId.DataValueField = "Id";
                drpModelId.DataTextField = "ModelText";
                drpModelId.DataBind();
            }
        }

        protected void drpBrandId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int brandId = int.Parse(drpBrandId.SelectedValue);
            Model m = new Model();
            drpModelId.DataSource = m.GetModels(brandId);
            drpModelId.DataValueField = "Id";
            drpModelId.DataTextField = "ModelText";
            drpModelId.DataBind();

            drpModelId.Enabled = true; 

        }
       
    }
}