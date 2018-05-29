using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ProduceModelMap : EntityTypeConfiguration<ProduceModel>
    {
        public ProduceModelMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProduceModel");
            this.Property(t => t.ProduceModelID).HasColumnName("ProduceModelID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
