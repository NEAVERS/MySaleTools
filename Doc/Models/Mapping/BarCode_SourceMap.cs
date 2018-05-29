using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BarCode_SourceMap : EntityTypeConfiguration<BarCode_Source>
    {
        public BarCode_SourceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Fullname, t.DecimalLength });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fullname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.DecimalLength)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BarCode_Source");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Fullname).HasColumnName("Fullname");
            this.Property(t => t.DecimalLength).HasColumnName("DecimalLength");
        }
    }
}
