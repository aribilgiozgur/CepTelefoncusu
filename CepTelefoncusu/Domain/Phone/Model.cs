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

        public Model() { }

        public Model(int Id) {
            String sql = "select * from Models where Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", Id);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.Id = reader.GetInt32(0);
                    this.BrandId = reader.GetInt32(1);
                    this.ModelText = reader.GetString(2);
                }
            }
            catch (Exception ex)
            {
                String msg = ex.Message;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }
        }

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

        public Boolean Save()
        {
            try
            {
                // 1. Adım: SQL yazılır
                String sql = "UPDATE Models SET BrandId = @BrandId, ModelText = @ModelText WHERE Id = @Id";

                // 2. Adım: SQL Command hazırlanır ve parametreleri geçilir.
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@BrandId", BrandId);
                cmd.Parameters.AddWithValue("@ModelText", ModelText);
                cmd.Parameters.AddWithValue("@Id", Id);

                // 3. Adım: Bağlantı açılır, işlem yapılır ve kapatılır.
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception ex)
            {
                String msg = ex.Message;
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }

        }
    }
}