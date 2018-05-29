using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ColumnsFieldMap : EntityTypeConfiguration<ColumnsField>
    {
        public ColumnsFieldMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.DataField });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DataField)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Fullname)
                .HasMaxLength(200);

            this.Property(t => t.ReportName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ColumnsField");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DataField).HasColumnName("DataField");
            this.Property(t => t.Fullname).HasColumnName("Fullname");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.ReportName).HasColumnName("ReportName");
        }
    }
}
