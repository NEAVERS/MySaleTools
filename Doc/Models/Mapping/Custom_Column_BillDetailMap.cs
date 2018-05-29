using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Custom_Column_BillDetailMap : EntityTypeConfiguration<Custom_Column_BillDetail>
    {
        public Custom_Column_BillDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.InOut);

            // Properties
            this.Property(t => t.Label)
                .HasMaxLength(200);

            this.Property(t => t.InOut)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Custom_Column_BillDetail");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.CustomColumnId).HasColumnName("CustomColumnId");
            this.Property(t => t.Label).HasColumnName("Label");
            this.Property(t => t.IsVisible).HasColumnName("IsVisible");
            this.Property(t => t.IsRequired).HasColumnName("IsRequired");
            this.Property(t => t.InOut).HasColumnName("InOut");
        }
    }
}
