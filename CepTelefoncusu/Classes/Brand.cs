using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CepTelefoncusu.Classes
{
    public class Brand : DbConn
    {
        public int Id { get; set; }
        public String BrandText { get; set; }

        // Insert
        public int Insert() {
            int phoneId = 0;
            
            String sql = "insert into Brands (BrandText) VALUES (@BrandText)";
            
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@BrandText", this.BrandText);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            
            // TODO: Return Last inserted Id

            return phoneId;
        
        }
        // Select

        public List<Brand> GetAll() 
        {
            List<Brand> brands = new List<Brand>();

            String sql = "select * from Brands";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                //int id = reader.GetInt32(0);
                //String brandText = reader.["BrandText"].ToString();

                Brand b = new Brand();
                b.Id = reader.GetInt32(0);
                b.BrandText = reader["BrandText"].ToString();

                brands.Add(b);

                
            }
            cnn.Close();
            return brands;
        }

        // Select All

        // Select One

        // Update
    }
}