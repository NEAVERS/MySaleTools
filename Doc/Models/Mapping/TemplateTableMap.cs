using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class TemplateTableMap : EntityTypeConfiguration<TemplateTable>
    {
        public TemplateTableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Templateid, t.TemplateName });

            // Properties
            this.Property(t => t.Templateid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TemplateName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.comment)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TemplateTable");
            this.Property(t => t.Templateid).HasColumnName("Templateid");
            this.Property(t => t.TemplateName).HasColumnName("TemplateName");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
