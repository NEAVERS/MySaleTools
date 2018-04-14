using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class CouponMap : EntityTypeConfiguration<Coupon>
    {
        public CouponMap()
        {
            this.ToTable("Coupon");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BrandId).HasColumnName("BrandId");

            this.Property(t => t.BrandName).HasColumnName("BrandName");
            this.Property(t => t.CouponType).HasColumnName("CouponType");

            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");

            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.EndTime).HasColumnName("EndTime");

            this.Property(t => t.IsUsed).HasColumnName("IsUsed");
            this.Property(t => t.LessMoney).HasColumnName("LessMoney");

            this.Property(t => t.Limit).HasColumnName("Limit");
            this.Property(t => t.Remark).HasColumnName("Remark");

            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.StoreId).HasColumnName("StoreId");

            this.Property(t => t.StoreNum).HasColumnName("StoreNum");
            this.Property(t => t.SupplierId).HasColumnName("SupplierId");

            this.Property(t => t.SupplierName).HasColumnName("SupplierName");
            this.Property(t => t.UserId).HasColumnName("UserId");

            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.UserNum).HasColumnName("UserNum");

            this.Property(t => t.UseTime).HasColumnName("UseTime");
            this.Property(t => t.UserOrderId).HasColumnName("UserOrderId");


            
        }
    }
}
