using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sms_Template_TypeMap : EntityTypeConfiguration<sms_Template_Type>
    {
        public sms_Template_TypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.typeID, t.TypeName });

            // Properties
            this.Property(t => t.typeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("sms_Template_Type");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
        }
    }
}
