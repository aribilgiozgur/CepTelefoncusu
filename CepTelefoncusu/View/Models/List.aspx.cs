using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View.Models
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model m = new Model();
            rptModels.DataSource = m.GetModels();
            rptModels.DataBind();
        }
    }
}