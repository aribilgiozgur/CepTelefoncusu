﻿using CepTelefoncusu.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CepTelefoncusu.Domain.Phone
{
    public class CellPhone : BaseClass
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public long SerialNo { get; set; }
        public double SalePrice { get; set; }
        public string Description { get; set; }
        public Boolean HasTouchScreen { get; set; }
        public Boolean HasBlueTooth { get; set; }
        public String OperatingSystem { get; set; }

        public String BrandText { get; set; }
        public String ModelText { get; set; }

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

        public List<CellPhone> GetAll() {
            List<CellPhone> phones = new List<CellPhone>();

            String sql = "Select * from phones p"
                + " inner join Brands b on p.BrandId = b.Id"
                + " inner join Models m on p.ModelId = m.Id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            // TODO: Paging
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                CellPhone c = new CellPhone();
                c.Id = int.Parse(reader["Id"].ToString());
                c.BrandId = int.Parse(reader["BrandId"].ToString());
                c.ModelId = int.Parse(reader["ModelId"].ToString());
                c.SerialNo = long.Parse(reader["SerialNo"].ToString());
                c.SalePrice = double.Parse(reader["SalePrice"].ToString());
                c.Description = reader["DescriptionText"].ToString();
                c.HasTouchScreen = bool.Parse(reader["HasTouchScreen"].ToString());
                c.HasBlueTooth = bool.Parse(reader["HasBlueTooth"].ToString());
                c.OperatingSystem = reader["OperatingSystem"].ToString();

                c.ModelText = reader["ModelText"].ToString();
                c.BrandText = reader["BrandText"].ToString();
                phones.Add(c);
            }
            cnn.Close();
            

            return phones;

        }
    }
}