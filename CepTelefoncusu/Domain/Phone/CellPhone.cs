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
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public long SerialNo { get; set; }
        public double BuyPrice { get; set; }
        public double SalePrice { get; set; }
        public string Description { get; set; }
        public Boolean HasTouchScreen { get; set; }
        public Boolean HasBlueTooth { get; set; }
        public String OperatingSystem { get; set; }
        public int Stock { get; set; }

        public String BrandText { get; set; }
        public String ModelText { get; set; }

        /*TODO: Diğer özellikler*/

        public void Insert() { 
            String sql = "insert into phones ("
            +" BrandId,ModelId,SerialNo,SalePrice,DescriptionText,HasTouchScreen,HasBlueTooth,OperatingSystem,Stock,BuyPrice"
            +" )VALUES ("
            +" @BrandId,@ModelId,@SerialNo,@SalePrice,@DescriptionText,@HasTouchScreen,@HasBlueTooth,@OperatingSystem,@Stock,@BuyPrice"
            +" )";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@BrandId", this.BrandId);
            cmd.Parameters.AddWithValue("@ModelId", this.ModelId);
            cmd.Parameters.AddWithValue("@SerialNo", this.SerialNo);
            cmd.Parameters.AddWithValue("@BuyPrice", this.BuyPrice);
            cmd.Parameters.AddWithValue("@SalePrice", this.SalePrice);
            cmd.Parameters.AddWithValue("@DescriptionText", this.Description);
            cmd.Parameters.AddWithValue("@HasTouchScreen", this.HasTouchScreen);
            cmd.Parameters.AddWithValue("@HasBlueTooth", this.HasBlueTooth);
            cmd.Parameters.AddWithValue("@OperatingSystem", this.OperatingSystem);
            cmd.Parameters.AddWithValue("@Stock", this.Stock);
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
                c.BuyPrice = double.Parse(reader["BuyPrice"].ToString());
                c.Stock = int.Parse(reader["Stock"].ToString());

                c.ModelText = reader["ModelText"].ToString();
                c.BrandText = reader["BrandText"].ToString();
                phones.Add(c);
            }
            cnn.Close();
            

            return phones;

        }

        public List<CellPhone> GetOne(int phoneId)
        {
            List<CellPhone> phones = new List<CellPhone>();

            String sql = "Select * from phones p"
                + " inner join Brands b on p.BrandId = b.Id"
                + " inner join Models m on p.ModelId = m.Id"
                + " where p.Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", phoneId);
            // TODO: Paging
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
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
                c.BuyPrice = double.Parse(reader["BuyPrice"].ToString());
                c.Stock = int.Parse(reader["Stock"].ToString());

                c.ModelText = reader["ModelText"].ToString();
                c.BrandText = reader["BrandText"].ToString();
                phones.Add(c);
            }
            cnn.Close();


            return phones;

        }
        public CellPhone()
        {

        }

        public CellPhone(int phoneId)
        {
            String sql = "Select * from phones p"
               + " inner join Brands b on p.BrandId = b.Id"
               + " inner join Models m on p.ModelId = m.Id"
               + " where p.Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", phoneId);
            // TODO: Paging
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.Id = int.Parse(reader["Id"].ToString());
                this.BrandId = int.Parse(reader["BrandId"].ToString());
                this.ModelId = int.Parse(reader["ModelId"].ToString());
                this.SerialNo = long.Parse(reader["SerialNo"].ToString());
                this.SalePrice = double.Parse(reader["SalePrice"].ToString());
                this.Description = reader["DescriptionText"].ToString();
                this.HasTouchScreen = bool.Parse(reader["HasTouchScreen"].ToString());
                this.HasBlueTooth = bool.Parse(reader["HasBlueTooth"].ToString());
                this.OperatingSystem = reader["OperatingSystem"].ToString();
                this.BuyPrice = double.Parse(reader["BuyPrice"].ToString());
                this.Stock = int.Parse(reader["Stock"].ToString());

                this.ModelText = reader["ModelText"].ToString();
                this.BrandText = reader["BrandText"].ToString();                
            }
            cnn.Close();
        }

        public void Delete() {
            String sql = "Delete from phones where Id = @Id";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", this.Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void Save() {
            String sql = "update phones set"
                + " BrandId = @BrandId,"
                + " ModelId = @ModelId,"
                + " SerialNo = @SerialNo,"
                + " SalePrice = @SalePrice,"
                + " DescriptionText = @Description,"
                + " HasTouchScreen = @HasTouchScreen,"
                + " HasBlueTooth = @HasBlueTooth,"
                + " OperatingSystem = @OperatingSystem,"
                + " Stock = @Stock,"
                + " BuyPrice = @BuyPrice"
                + " where"
                + " Id = @Id";

            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@BrandId", this.BrandId);
            cmd.Parameters.AddWithValue("@ModelId", this.ModelId);
            cmd.Parameters.AddWithValue("@SerialNo", this.SerialNo);
            cmd.Parameters.AddWithValue("@SalePrice", this.SalePrice);
            cmd.Parameters.AddWithValue("@Description", this.Description);
            cmd.Parameters.AddWithValue("@HasTouchScreen", this.HasTouchScreen);
            cmd.Parameters.AddWithValue("@HasBlueTooth", this.HasBlueTooth);
            cmd.Parameters.AddWithValue("@OperatingSystem", this.OperatingSystem);
            cmd.Parameters.AddWithValue("@BuyPrice", this.BuyPrice);
            cmd.Parameters.AddWithValue("@Stock", this.Stock);
            cmd.Parameters.AddWithValue("@Id", this.Id);

            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
}