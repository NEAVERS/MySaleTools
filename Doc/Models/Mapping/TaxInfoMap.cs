using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class TaxInfoMap : EntityTypeConfiguration<TaxInfo>
    {
        public TaxInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.TaxID);

            // Properties
            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.PyCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TaxInfo");
            this.Property(t => t.TaxID).HasColumnName("TaxID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.TaxType).HasColumnName("TaxType");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
        }
    }
}
