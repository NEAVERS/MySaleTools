using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceBillIndex_StypeMap : EntityTypeConfiguration<PriceBillIndex_Stype>
    {
        public PriceBillIndex_StypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PriceBillIndexID, t.StypeID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PriceBillIndexID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceBillIndex_Stype");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PriceBillIndexID).HasColumnName("PriceBillIndexID");
            this.Property(t => t.StypeID).HasColumnName("StypeID");
        }
    }
}
