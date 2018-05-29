using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BeforePromoteIndexMap : EntityTypeConfiguration<BeforePromoteIndex>
    {
        public BeforePromoteIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.BillCode)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BeforePromoteIndex");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
        }
    }
}
