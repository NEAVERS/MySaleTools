using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sms_TemplateMap : EntityTypeConfiguration<sms_Template>
    {
        public sms_TemplateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TemplateID, t.TypeID, t.Content });

            // Properties
            this.Property(t => t.TemplateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("sms_Template");
            this.Property(t => t.TemplateID).HasColumnName("TemplateID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.Content).HasColumnName("Content");
        }
    }
}
