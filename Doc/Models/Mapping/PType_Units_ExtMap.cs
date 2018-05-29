using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PType_Units_ExtMap : EntityTypeConfiguration<PType_Units_Ext>
    {
        public PType_Units_ExtMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PtypeID, t.UnitsId, t.RateType, t.IsDefaultUnit });

            // Properties
            this.Property(t => t.PtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitsId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RateType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EntryCode)
                .HasMaxLength(200);

            this.Property(t => t.IsDefaultUnit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PType_Units_Ext");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.UnitsId).HasColumnName("UnitsId");
            this.Property(t => t.RateType).HasColumnName("RateType");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.EntryCode).HasColumnName("EntryCode");
            this.Property(t => t.IsDefaultUnit).HasColumnName("IsDefaultUnit");
            this.Property(t => t.IsUse).HasColumnName("IsUse");
        }
    }
}
