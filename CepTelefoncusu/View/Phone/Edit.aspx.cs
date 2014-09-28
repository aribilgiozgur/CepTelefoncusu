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
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                int Id = int.Parse(Request.QueryString["Id"].ToString());
                Session["PhoneId"] = Id;
                
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

                CellPhone c = new CellPhone(Id);
                drpBrandId.SelectedValue = c.BrandId.ToString();
                drpModelId.SelectedValue = c.ModelId.ToString();
                txtSerialNo.Text = c.SerialNo.ToString();
                txtBuyPrice.Text = c.BuyPrice.ToString();
                txtSalePrice.Text = c.SalePrice.ToString();
                txtDescription.Text = c.Description;
                txtOperatingSystem.Text = c.OperatingSystem;
                chkBlueTooth.Checked = c.HasBlueTooth;
                chkTouchScreen.Checked = c.HasTouchScreen;
                txtStock.Text = c.Stock.ToString();


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
            int PhoneId = int.Parse(Session["PhoneId"].ToString());
            CellPhone c = new CellPhone(PhoneId);           

            c.BrandId = int.Parse(drpBrandId.SelectedValue);
            c.ModelId = int.Parse(drpModelId.SelectedValue);
            c.SerialNo = long.Parse(txtSerialNo.Text);
            c.BuyPrice = double.Parse(txtBuyPrice.Text);
            c.SalePrice = double.Parse(txtSalePrice.Text);
            c.Description = txtDescription.Text;
            c.OperatingSystem = txtOperatingSystem.Text;
            c.HasTouchScreen = chkTouchScreen.Checked;
            c.HasBlueTooth = chkBlueTooth.Checked;
            c.Stock = int.Parse(txtStock.Text);

            c.Save();
            Response.Redirect("List.aspx");


        }
    }
}