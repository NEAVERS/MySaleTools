using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosCommonSysDataMap : EntityTypeConfiguration<PosCommonSysData>
    {
        public PosCommonSysDataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SysID, t.SysName, t.SysValue });

            // Properties
            this.Property(t => t.SysID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SysName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SysValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SysComment)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("PosCommonSysData");
            this.Property(t => t.SysID).HasColumnName("SysID");
            this.Property(t => t.SysName).HasColumnName("SysName");
            this.Property(t => t.SysValue).HasColumnName("SysValue");
            this.Property(t => t.SysComment).HasColumnName("SysComment");
        }
    }
}
