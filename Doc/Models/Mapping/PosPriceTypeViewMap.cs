using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosPriceTypeViewMap : EntityTypeConfiguration<PosPriceTypeView>
    {
        public PosPriceTypeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SortLevel, t.IsSystem });

            // Properties
            this.Property(t => t.BranchId)
                .HasMaxLength(30);

            this.Property(t => t.PriceTypeId)
                .HasMaxLength(30);

            this.Property(t => t.PriceName)
                .HasMaxLength(30);

            this.Property(t => t.DisplayName)
                .HasMaxLength(30);

            this.Property(t => t.Type)
                .HasMaxLength(30);

            this.Property(t => t.SortLevel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsSystem)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosPriceTypeView");
            this.Property(t => t.BranchId).HasColumnName("BranchId");
            this.Property(t => t.PriceTypeId).HasColumnName("PriceTypeId");
            this.Property(t => t.PriceName).HasColumnName("PriceName");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.SortLevel).HasColumnName("SortLevel");
            this.Property(t => t.IsSystem).HasColumnName("IsSystem");
        }
    }
}
