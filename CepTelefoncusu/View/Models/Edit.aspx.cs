using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View.Models
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Brand b = new Brand();
                drpMarka.DataSource = b.GetAll();
                drpMarka.DataValueField = "Id";
                drpMarka.DataTextField = "BrandText";
                drpMarka.DataBind();
                
                // Session'a Id ataması
                int Id = int.Parse(Request.QueryString["Id"]);
                Session["Id"] = Id;
                Model m = new Model(Id);

                drpMarka.SelectedValue = m.BrandId.ToString();
                txtModel.Text = m.ModelText;

            }
        }

        protected void lnkSend_Click(object sender, EventArgs e)
        {
            // Session'dan Id alma
            int Id = int.Parse(Session["Id"].ToString());
            int brandId = int.Parse(drpMarka.SelectedValue);
            String modelText = txtModel.Text;

            // Modeli getirip güncelleyip db'ye kaydetmek
            Model m = new Model(Id);
            m.BrandId = brandId;
            m.ModelText = modelText;
            m.Save();
            Response.Redirect("List.aspx");

        }
    }
}