using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("Area");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Num).HasColumnName("Num");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentNum).HasColumnName("ParentNum");
            this.Property(t => t.ParentName).HasColumnName("ParentName");


        }
    }
}
