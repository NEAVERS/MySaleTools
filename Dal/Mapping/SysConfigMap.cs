using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class SysConfigMap : EntityTypeConfiguration<SysConfig>
    {
        public SysConfigMap()
        {
            this.ToTable("SysConfig");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
        }
    }
}
