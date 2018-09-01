using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{


    class BlackForActiveMap : EntityTypeConfiguration<BlackForActive>
    {
        public BlackForActiveMap()
        {
            this.HasKey(x => x.Id);
            this.ToTable("BlackForActive");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GoodsNum).HasColumnName("GoodsNum");
            this.Property(t => t.GoodsId).HasColumnName("GoodsId");
            this.Property(t => t.GoodsName).HasColumnName("GoodsName");
            this.Property(t => t.ProviderName).HasColumnName("ProviderName");
            this.Property(t => t.Satutas).HasColumnName("Satutas");
            this.Property(t => t.ActiveType).HasColumnName("ActiveType");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");

        }
    }

}
