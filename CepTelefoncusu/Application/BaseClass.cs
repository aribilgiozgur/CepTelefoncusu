using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CepTelefoncusu.Classes
{
    public class BaseClass : DbConn 
    {
        public int Id;
        public DateTime CreateDate;
        public int CreateUser;
        public DateTime EditDate;
        public int EditUser;

    }
}