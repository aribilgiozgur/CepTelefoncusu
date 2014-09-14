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

                int Id = int.Parse(Request.QueryString["Id"]);
                Model m = new Model();
                Model m1 = m.GetModel(Id);

                drpMarka.SelectedValue = m1.BrandId.ToString();
                txtModel.Text = m1.ModelText;

            }
        }
    }
}