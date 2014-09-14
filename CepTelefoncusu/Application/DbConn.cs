using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CepTelefoncusu.Classes
{
    public class DbConn
    {
        // Normal sınıf
        //public SqlConnection cnn = new SqlConnection("Server=localhost\\SQLEXPRESS; Database=CepTelDB; Trusted_Connection = true;");
        // VS 2012 Sınıfı
        public static SqlConnection cnn = new SqlConnection("Server=.; Database=CepTelDB; Trusted_Connection = true;");
        
        
    }
}