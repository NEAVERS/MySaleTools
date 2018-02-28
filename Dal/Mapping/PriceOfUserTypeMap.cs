using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    
    public class PriceOfUserTypeMap : EntityTypeConfiguration<PriceOfUserType>
    {
        public PriceOfUserTypeMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("PriceOfUserType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GoodsId).HasColumnName("GoodsId");
            this.Property(t => t.UserTypeId).HasColumnName("UserTypeId");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }

    }
}
