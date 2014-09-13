using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CepTelefoncusu.Classes
{
    public class BaseClass :DbConn 
    {
        public int Id;
        public DateTime CreateDate;
        public int CreateUser;
        public DateTime EditDate;
        public int EditUser;

        /*
        public int Insert()
        {
            int phoneId = 0;
            String tableName = "Models";
            String columnNamesString = "";
            List<String> columnNames = new List<String>();
            columnNames.Add("BrandId");
            columnNames.Add("ModelText");

            int columnLength = columnNames.Count();
            int i = 1;

            foreach (String columnName in columnNames)
            {
                columnNamesString += columnName;              
                if (i != columnLength) columnNamesString += ",";
                i++;
            }

            String sql = "insert into "+tableName+" ("+columnNamesString+") VALUES (@BrandId,@ModelText)";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@BrandText", this.BrandText);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            // TODO: Return Last inserted Id

            return phoneId;

        }  */

    }
}