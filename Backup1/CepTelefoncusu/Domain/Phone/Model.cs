using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CepTelefoncusu.Classes
{
    public class Model : BaseClass
    {
        public int BrandId { get; set; }
        public String ModelText { get; set; }

        // Insert
        public int Insert()
        {
            int phoneId = 0;

            String sql = "insert into Models (BrandId, ModelText) VALUES (@BrandId,@ModelText)";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@BrandId", this.BrandId);
            cmd.Parameters.AddWithValue("@ModelText", this.ModelText); 
           
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            // TODO: Return Last inserted Id

            return phoneId;

        }        
    }
}