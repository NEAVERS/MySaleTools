using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_GuestWLDZMap : EntityTypeConfiguration<vWeb_GuestWLDZ>
    {
        public vWeb_GuestWLDZMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BID, t.BDate, t.BCode, t.Btype });

            // Properties
            this.Property(t => t.BID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Btype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Btypeid)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(261);

            // Table & Column Mappings
            this.ToTable("vWeb_GuestWLDZ");
            this.Property(t => t.BID).HasColumnName("BID");
            this.Property(t => t.BDate).HasColumnName("BDate");
            this.Property(t => t.BCode).HasColumnName("BCode");
            this.Property(t => t.Btype).HasColumnName("Btype");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
            this.Property(t => t.ApAdd).HasColumnName("ApAdd");
            this.Property(t => t.ApReduce).HasColumnName("ApReduce");
            this.Property(t => t.TeamNo1).HasColumnName("TeamNo1");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
