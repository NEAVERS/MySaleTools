using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CM_CarUseBillMap : EntityTypeConfiguration<CM_CarUseBill>
    {
        public CM_CarUseBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.CarId, t.Usestartdate, t.Useenddate });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.CarId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Driver)
                .HasMaxLength(50);

            this.Property(t => t.Etypeid)
                .HasMaxLength(50);

            this.Property(t => t.Destination)
                .HasMaxLength(200);

            this.Property(t => t.Use)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CM_CarUseBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.CarId).HasColumnName("CarId");
            this.Property(t => t.Driver).HasColumnName("Driver");
            this.Property(t => t.Etypeid).HasColumnName("Etypeid");
            this.Property(t => t.Destination).HasColumnName("Destination");
            this.Property(t => t.Use).HasColumnName("Use");
            this.Property(t => t.Usestartdate).HasColumnName("Usestartdate");
            this.Property(t => t.Useenddate).HasColumnName("Useenddate");
        }
    }
}
