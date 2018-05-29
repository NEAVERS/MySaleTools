using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AccountSubjectSetMap : EntityTypeConfiguration<AccountSubjectSet>
    {
        public AccountSubjectSetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SoftType, t.ATypeID, t.SubjectCode, t.J_D });

            // Properties
            this.Property(t => t.SoftType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ATypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SubjectCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.J_D)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("AccountSubjectSet");
            this.Property(t => t.SoftType).HasColumnName("SoftType");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.SubjectCode).HasColumnName("SubjectCode");
            this.Property(t => t.J_D).HasColumnName("J_D");
        }
    }
}
