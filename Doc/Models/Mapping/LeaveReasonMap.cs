using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class LeaveReasonMap : EntityTypeConfiguration<LeaveReason>
    {
        public LeaveReasonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Fullname, t.Comment });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Fullname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("LeaveReason");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fullname).HasColumnName("Fullname");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
