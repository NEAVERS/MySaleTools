using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class V3ZTInfoMap : EntityTypeConfiguration<V3ZTInfo>
    {
        public V3ZTInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ZTCode, t.ZTName, t.Display, t.Deleted, t.DispOrder, t.Actived });

            // Properties
            this.Property(t => t.ZTCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ZTName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Display)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Deleted)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DispOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Actived)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("V3ZTInfo");
            this.Property(t => t.ZTCode).HasColumnName("ZTCode");
            this.Property(t => t.ZTName).HasColumnName("ZTName");
            this.Property(t => t.Display).HasColumnName("Display");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.DispOrder).HasColumnName("DispOrder");
            this.Property(t => t.Actived).HasColumnName("Actived");
        }
    }
}
