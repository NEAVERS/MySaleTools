using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CM_FeeTypeMap : EntityTypeConfiguration<CM_FeeType>
    {
        public CM_FeeTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FeeTypeId, t.Usercode, t.Fullname });

            // Properties
            this.Property(t => t.FeeTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Usercode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Fullname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("CM_FeeType");
            this.Property(t => t.FeeTypeId).HasColumnName("FeeTypeId");
            this.Property(t => t.Usercode).HasColumnName("Usercode");
            this.Property(t => t.Fullname).HasColumnName("Fullname");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
