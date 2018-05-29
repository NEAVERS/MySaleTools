using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SchemeDetailMap : EntityTypeConfiguration<SchemeDetail>
    {
        public SchemeDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nId, t.SchemeId, t.DataField, t.DataValue });

            // Properties
            this.Property(t => t.nId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SchemeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DataField)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.DataValue)
                .IsRequired();

            this.Property(t => t.DataText)
                .HasMaxLength(500);

            this.Property(t => t.ControlType)
                .HasMaxLength(200);

            this.Property(t => t.BaseType)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SchemeDetail");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.SchemeId).HasColumnName("SchemeId");
            this.Property(t => t.DataField).HasColumnName("DataField");
            this.Property(t => t.DataValue).HasColumnName("DataValue");
            this.Property(t => t.DataText).HasColumnName("DataText");
            this.Property(t => t.ControlType).HasColumnName("ControlType");
            this.Property(t => t.BaseType).HasColumnName("BaseType");
        }
    }
}
