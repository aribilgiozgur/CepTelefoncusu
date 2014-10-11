using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CepTelefoncusu.Application
{
    public class CepUser
    {
        public int Id { get; set; }
        public String userName { get; set; }
        public String passWord { get; set; }
        public String fullName { get; set; }

        public static int CheckUser(String userName, String passWord) {
            int userId = -1;

            SqlConnection cnn = new SqlConnection("Server=.; Database=CepTelDB; Trusted_Connection = true;");
            String sql = "select Id from CepUsers where UserName = @UserName and Password = @Password";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@Password", passWord);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0) != 0)
                {
                    userId = reader.GetInt32(0);                   
                }
            }        
            reader.Close();
            cnn.Close();
            return userId;
        }

        public static String GetRealName(int userId) {
            String realName = "";
           
            SqlConnection cnn = new SqlConnection("Server=.; Database=CepTelDB; Trusted_Connection=true");
            String sql = "select RealName from CepUsers where Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", userId);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               realName =  reader.GetString(0);
            }
            reader.Close();
            cnn.Close();
           
            return realName;
        }
    }
}