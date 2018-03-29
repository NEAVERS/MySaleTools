using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class UserInfoMap : EntityTypeConfiguration<UserInfo>
    {
        public UserInfoMap()
        {
            this.HasKey(x => x.UserId);
            this.ToTable("UserInfo");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.UserNum).HasColumnName("UserNum");
            this.Property(t => t.Account).HasColumnName("Account");
            this.Property(t => t.PassWord).HasColumnName("PassWord");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.IsLocked).HasColumnName("IsLocked");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");

            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.ProvinceNum).HasColumnName("ProvinceNum");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.CityNum).HasColumnName("CityNum");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.AreaNum).HasColumnName("AreaNum");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.SaleManGuid).HasColumnName("SaleManGuid");
            this.Property(t => t.SaleManName).HasColumnName("SaleManName");


            this.Property(t => t.ReceiveName).HasColumnName("ReceiveName");
            this.Property(t => t.Addr).HasColumnName("Addr");
            this.Property(t => t.StoreArea).HasColumnName("StoreArea");
            this.Property(t => t.SotreName).HasColumnName("SotreName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Remark).HasColumnName("Remark");
            



        }
    }
}
