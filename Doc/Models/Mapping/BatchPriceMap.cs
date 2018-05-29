using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BatchPriceMap : EntityTypeConfiguration<BatchPrice>
    {
        public BatchPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DepartId)
                .HasMaxLength(100);

            this.Property(t => t.DepartUserCode)
                .HasMaxLength(256);

            this.Property(t => t.DepartFullName)
                .HasMaxLength(1000);

            this.Property(t => t.PTypeId)
                .HasMaxLength(100);

            this.Property(t => t.PUserCode)
                .HasMaxLength(256);

            this.Property(t => t.PFullName)
                .HasMaxLength(1000);

            this.Property(t => t.PEntryCode)
                .HasMaxLength(50);

            this.Property(t => t.PStandard)
                .HasMaxLength(50);

            this.Property(t => t.PType)
                .HasMaxLength(50);

            this.Property(t => t.Explain)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("BatchPrice");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.DepartId).HasColumnName("DepartId");
            this.Property(t => t.DepartUserCode).HasColumnName("DepartUserCode");
            this.Property(t => t.DepartFullName).HasColumnName("DepartFullName");
            this.Property(t => t.PTypeId).HasColumnName("PTypeId");
            this.Property(t => t.PUserCode).HasColumnName("PUserCode");
            this.Property(t => t.PFullName).HasColumnName("PFullName");
            this.Property(t => t.PEntryCode).HasColumnName("PEntryCode");
            this.Property(t => t.PStandard).HasColumnName("PStandard");
            this.Property(t => t.PType).HasColumnName("PType");
            this.Property(t => t.PrePrice1).HasColumnName("PrePrice1");
            this.Property(t => t.PrePrice2).HasColumnName("PrePrice2");
            this.Property(t => t.PrePrice3).HasColumnName("PrePrice3");
            this.Property(t => t.PrePrice4).HasColumnName("PrePrice4");
            this.Property(t => t.recPrice).HasColumnName("recPrice");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.Default).HasColumnName("Default");
        }
    }
}
