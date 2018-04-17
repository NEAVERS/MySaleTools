using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class GoodsTypeMap : EntityTypeConfiguration<GoodsType>
    {
        public GoodsTypeMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("GoodsType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.ParentName).HasColumnName("ParentName");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.IsShowFirstPage).HasColumnName("IsShowFirstPage");

            
        }

    }
}
