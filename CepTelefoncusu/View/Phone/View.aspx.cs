using CepTelefoncusu.Domain.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View.Phone
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int phoneId = int.Parse(Request.QueryString["Id"].ToString());
            CellPhone c = new CellPhone();

            rptPhone.DataSource = c.GetOne(phoneId);
            rptPhone.DataBind();

        }
    }
}