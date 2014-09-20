using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CepTelefoncusu.Domain.Phone
{
    public class CellPhone : BaseClass
    {
        public int BrandId;
        public int ModelId;
        public int SerialNo;
        public double SalePrice;
        public string Description;
        public Boolean HasTouchScreen;
        public Boolean HasBlueTooth;
        public String OperatingSystem;
        /*TODO: Diğer özellikler*/

    }
}