using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Sys_BaseInfoUsing_TablesMap : EntityTypeConfiguration<Sys_BaseInfoUsing_Tables>
    {
        public Sys_BaseInfoUsing_TablesMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.tblName)
                .HasMaxLength(50);

            this.Property(t => t.fldName)
                .HasMaxLength(50);

            this.Property(t => t.basType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sys_BaseInfoUsing_Tables");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.tblName).HasColumnName("tblName");
            this.Property(t => t.fldName).HasColumnName("fldName");
            this.Property(t => t.basType).HasColumnName("basType");
        }
    }
}
