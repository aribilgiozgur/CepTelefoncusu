using CepTelefoncusu.Domain.Phone;
using CepTelefoncusu.Domain.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CepTelefoncusu.View.Sales
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                CellPhone cp = new CellPhone();
                List<CellPhone>cellphones = cp.GetAll();
                foreach (CellPhone cellphone in cellphones)
                {
                    ListItem li = new ListItem();
                    li.Text = cellphone.BrandText + " - " + cellphone.ModelText;
                    li.Value = cellphone.Id.ToString();
                    drpProductId.Items.Add(li);
                }
            }
        }

        protected void lnkSatis_Click(object sender, EventArgs e)
        {
            /*
               public int ProductId { get; set; }
        public int SaleStock { get; set; }
        public double BasePrice { get; set; }
        public DateTime SaleDate { get; set; }
        public int SaleType { get; set; }
             
             */
            Sale s = new Sale();
            s.ProductId = int.Parse(drpProductId.SelectedValue);
            s.SaleStock = int.Parse(txtSaleStock.Text);
            s.BasePrice = double.Parse(txtBasePrice.Text);
            s.SaleDate = calSaleDate.SelectedDate;
            s.SaleType = int.Parse(drpSaleType.SelectedValue);
            s.CreateUser = 1;

            CellPhone cp = new CellPhone(s.ProductId);
            


            s.Insert();

        }
    }
}