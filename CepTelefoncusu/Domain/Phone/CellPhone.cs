using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void Insert() { 
            String sql = "insert into phones ("
            +" BrandId,ModelId,SerialNo,SalePrice,DescriptionText,HasTouchScreen,HasBlueTooth,OperatingSystem"
            +" )VALUES ("
            +" @BrandId,@ModelId,@SerialNo,@SalePrice,@DescriptionText,@HasTouchScreen,@HasBlueTooth,@OperatingSystem"
            +" )";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@BrandId", this.BrandId);
            cmd.Parameters.AddWithValue("@ModelId", this.ModelId);
            cmd.Parameters.AddWithValue("@SerialNo", this.SerialNo);
            cmd.Parameters.AddWithValue("@SalePrice", this.SalePrice);
            cmd.Parameters.AddWithValue("@DescriptionText", this.Description);
            cmd.Parameters.AddWithValue("@HasTouchScreen", this.HasTouchScreen);
            cmd.Parameters.AddWithValue("@HasBlueTooth", this.HasBlueTooth);
            cmd.Parameters.AddWithValue("@OperatingSystem", this.OperatingSystem);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
}