using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CepTelefoncusu.Classes
{
    public class Model : BaseClass
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public String ModelText { get; set; }
        public String BrandText { get; set; }

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

        public List<Model> GetModels() {
            List<Model> models = new List<Model>();

            String sql = "select"
            +" m.Id,b.BrandText,m.ModelText"
            +" from Models m"
            +" INNER JOIN Brands b ON b.Id = m.BrandId";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Model m = new Model();
                    m.Id = reader.GetInt32(0);
                    m.BrandText = reader.GetString(1);
                    m.ModelText = reader.GetString(2);
                    models.Add(m);
                }
            }
            catch (Exception ex)
            {
                String msg = ex.Message;
            }
            finally
            {      if(cnn.State == ConnectionState.Open) cnn.Close();
            }
            return models;
        }

    }
}