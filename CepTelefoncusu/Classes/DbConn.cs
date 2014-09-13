using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CepTelefoncusu.Classes
{
    public class DbConn
    {
        public SqlConnection cnn = new SqlConnection("Server=.; Database=CepTelDB; Trusted_Connection = true;");
        
    }
}