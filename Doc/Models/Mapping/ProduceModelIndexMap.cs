using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ProduceModelIndexMap : EntityTypeConfiguration<ProduceModelIndex>
    {
        public ProduceModelIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.ProduceModelID);

            // Properties
            this.Property(t => t.ProduceModelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProduceModelName)
                .HasMaxLength(66);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("ProduceModelIndex");
            this.Property(t => t.ProduceModelID).HasColumnName("ProduceModelID");
            this.Property(t => t.ProduceModelName).HasColumnName("ProduceModelName");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
