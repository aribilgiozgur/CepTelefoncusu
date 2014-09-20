using CepTelefoncusu.Classes;
using CepTelefoncusu.Domain.Phone;
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

        protected void lnkSend_Click(object sender, EventArgs e)
        {
            CellPhone cp = new CellPhone();
            
            cp.BrandId = int.Parse(drpBrandId.SelectedValue);
            cp.ModelId = int.Parse(drpModelId.SelectedValue);
            cp.SerialNo = int.Parse(txtSerialNo.Text);
            cp.SalePrice = double.Parse(txtPrice.Text);
            cp.Description = txtDescription.Text;
            cp.OperatingSystem = txtOperatingSystem.Text;
            cp.HasTouchScreen = chkTouchScreen.Checked;
            cp.HasBlueTooth = chkBlueTooth.Checked;

            cp.Insert();

            Response.Redirect("/index.aspx");


        }
       
    }
}