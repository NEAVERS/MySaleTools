using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_nVipCardSign_RemindEventMap : EntityTypeConfiguration<QP_nVipCardSign_RemindEvent>
    {
        public QP_nVipCardSign_RemindEventMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VipCardID, t.ID, t.RemindContent, t.RemindDate });

            // Properties
            this.Property(t => t.VipCardID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RemindContent)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("QP_nVipCardSign_RemindEvent");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RemindContent).HasColumnName("RemindContent");
            this.Property(t => t.RemindDate).HasColumnName("RemindDate");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
