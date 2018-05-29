using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sms_signatureMap : EntityTypeConfiguration<sms_signature>
    {
        public sms_signatureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.signatureNo, t.signature });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.signatureNo)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.signature)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.employee)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sms_signature");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.signatureNo).HasColumnName("signatureNo");
            this.Property(t => t.signature).HasColumnName("signature");
            this.Property(t => t.employee).HasColumnName("employee");
        }
    }
}
