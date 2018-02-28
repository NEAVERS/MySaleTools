using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class GoodsBrandMap : EntityTypeConfiguration<GoodsBrand>
    {
        public GoodsBrandMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("GoodsBrand");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BrandName).HasColumnName("BrandName");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");


        }
    }
}
