using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CepTelefoncusu.Classes;

namespace CepTelefoncusu.View.Models
{
    public partial class Add : System.Web.UI.Page
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
            }

                
        }

        protected void lnkSend_Click(object sender, EventArgs e)
        {
            Model m = new Model();
            m.BrandId = int.Parse(drpMarka.SelectedValue);
            m.ModelText = txtModel.Text;
            m.Insert();
            Response.Redirect("../../index.aspx"); // TODO: Listeye çevir
        }
    }
}