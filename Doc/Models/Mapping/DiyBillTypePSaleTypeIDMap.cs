using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DiyBillTypePSaleTypeIDMap : EntityTypeConfiguration<DiyBillTypePSaleTypeID>
    {
        public DiyBillTypePSaleTypeIDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DiyBillTypeId, t.SalebillNumberId });

            // Properties
            this.Property(t => t.DiyBillTypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SalebillNumberId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ifcheck)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DiyBillTypePSaleTypeID");
            this.Property(t => t.DiyBillTypeId).HasColumnName("DiyBillTypeId");
            this.Property(t => t.SalebillNumberId).HasColumnName("SalebillNumberId");
            this.Property(t => t.ifcheck).HasColumnName("ifcheck");
        }
    }
}
