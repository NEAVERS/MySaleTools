using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosIsUpdateDataMap : EntityTypeConfiguration<PosIsUpdateData>
    {
        public PosIsUpdateDataMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.tbType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PosIsUpdateData");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.tbType).HasColumnName("tbType");
            this.Property(t => t.Tid).HasColumnName("Tid");
            this.Property(t => t.ifUpdate).HasColumnName("ifUpdate");
            this.Property(t => t.stypeid).HasColumnName("stypeid");
        }
    }
}
