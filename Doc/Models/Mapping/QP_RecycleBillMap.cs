using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_RecycleBillMap : EntityTypeConfiguration<QP_RecycleBill>
    {
        public QP_RecycleBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.PTypeID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_RecycleBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
        }
    }
}
