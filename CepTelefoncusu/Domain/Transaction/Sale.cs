using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CepTelefoncusu.Domain.Transaction
{
    public class Sale : DbConn
    {
        public int Id { get; set; }
        
        // public bool isService { get; set; }
        public int ProductId { get; set; }
        public int SaleStock { get; set; }
        public double BasePrice { get; set; }
        public DateTime SaleDate { get; set; }
        public int SaleType { get; set; }
        // TODO: Customer Domain
        // public int CustomerId { get; set; }
        
        public DateTime CreateDate;
        public int CreateUser;
        public DateTime EditDate;
        public int EditUser;

        public void Insert() {
            String sql = "insert into Sales "
            +"(ProductId,SaleStock,BasePrice,SaleDate,SaleType,CreateUser)"
            +"values"
            +"(@ProductId,@SaleStock,@BasePrice,@SaleDate,@SaleType,@CreateUser)";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ProductId", this.ProductId);
            cmd.Parameters.AddWithValue("@SaleStock", this.SaleStock);
            cmd.Parameters.AddWithValue("@BasePrice", this.BasePrice);
            cmd.Parameters.AddWithValue("@SaleDate", this.SaleDate);
            cmd.Parameters.AddWithValue("@SaleType", this.SaleType);
            cmd.Parameters.AddWithValue("@CreateUser", this.CreateUser);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }



    }
}