using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class wx_IniOutRepairMap : EntityTypeConfiguration<wx_IniOutRepair>
    {
        public wx_IniOutRepairMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PtypeID, t.BtypeID, t.Qty });

            // Properties
            this.Property(t => t.PtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Qty)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("wx_IniOutRepair");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.BtypeID).HasColumnName("BtypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
