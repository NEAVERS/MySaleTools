using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    class ManToAreaMap : EntityTypeConfiguration<ManToArea>
    {

        public ManToAreaMap()
        {
            this.ToTable("ManToArea");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ActiveId).HasColumnName("ActiveId");
            this.Property(t => t.ActiveName).HasColumnName("ActiveName");
            this.Property(t => t.AreaNum).HasColumnName("AreaNum");
            this.Property(t => t.AreaName).HasColumnName("AreaName");
        }
    }
}
