using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_BackBillCodeSeedMap : EntityTypeConfiguration<OM_BackBillCodeSeed>
    {
        public OM_BackBillCodeSeedMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FlowDate)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("OM_BackBillCodeSeed");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FlowDate).HasColumnName("FlowDate");
            this.Property(t => t.Seed).HasColumnName("Seed");
        }
    }
}
