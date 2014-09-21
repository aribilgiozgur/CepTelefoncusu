using CepTelefoncusu.Domain.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View.Phone
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CellPhone c = new CellPhone();
            rptPhones.DataSource = c.GetAll();
            rptPhones.DataBind();
        }
    }
}