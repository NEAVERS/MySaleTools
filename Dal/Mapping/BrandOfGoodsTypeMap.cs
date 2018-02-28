using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class BrandOfGoodsTypeMap : EntityTypeConfiguration<BrandOfGoodsType>
    {
        public BrandOfGoodsTypeMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("BrandOfGoodsType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BandsId).HasColumnName("BandsId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");



        }
    }
}
