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

        public Brand()
        {

        }

        public Brand(int p_Id) {
            String sql = "Select * from Brands where Id=@Id";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", p_Id);
            
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            
            this.Id = int.Parse(reader["Id"].ToString());
            this.BrandText = reader["BrandText"].ToString();

            cnn.Close();

        }
        
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


        // Select All

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
        

        // Update

        public bool Save()
        {
            bool isSuccessful = false;

            try
            {
                String sql = "update Brands set BrandText = @BrandText where Id = @Id";

                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Id", this.Id);
                cmd.Parameters.AddWithValue("@BrandText", this.BrandText);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                
                isSuccessful = true;
            }
            catch (Exception ex) { 
            
            }
            return isSuccessful;
        }

        public bool Delete() {
            bool isSuccessful = false;
            try
            {
                String sql = "delete from Brands where Id = @Id";

                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Id", this.Id);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                
                isSuccessful = true;
            }
            catch (Exception ex) { 
            
            }

            return isSuccessful;
        }
    }
}