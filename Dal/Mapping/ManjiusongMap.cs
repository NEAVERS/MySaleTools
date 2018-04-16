using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class ManjiusongMap : EntityTypeConfiguration<Manjiusong>
    {
        public ManjiusongMap()
        {
            this.ToTable("Manjiusong");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.LimitMoney).HasColumnName("LimitMoney");
            this.Property(t => t.SendGoodId).HasColumnName("SendGoodId");
            this.Property(t => t.UserTypes).HasColumnName("UserTypes");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.Tittle).HasColumnName("Tittle");
            this.Property(t => t.SendGoodNum).HasColumnName("SendGoodNum");
            this.Property(t => t.SendGoodName).HasColumnName("SendGoodName");
            this.Property(t => t.SendGoodCount).HasColumnName("SendGoodCount");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.SupplierId).HasColumnName("SupplierId");
            this.Property(t => t.SupplierName).HasColumnName("SupplierName");
            this.Property(t => t.BrandId).HasColumnName("BrandId");
            this.Property(t => t.BrandName).HasColumnName("BrandName");

        }
    }
}
