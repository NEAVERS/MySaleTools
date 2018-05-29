using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosPtypePriceViewMap : EntityTypeConfiguration<PosPtypePriceView>
    {
        public PosPtypePriceViewMap()
        {
            // Primary Key
            this.HasKey(t => t.Ptypeid);

            // Properties
            this.Property(t => t.PriceTypeId)
                .HasMaxLength(30);

            this.Property(t => t.Ptypeid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PosPtypePriceView");
            this.Property(t => t.PriceTypeId).HasColumnName("PriceTypeId");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
