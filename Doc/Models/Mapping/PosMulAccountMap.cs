using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosMulAccountMap : EntityTypeConfiguration<PosMulAccount>
    {
        public PosMulAccountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BillNumberId, t.paymoney });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PayStyle)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.paymoney)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosMulAccount");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.PayStyle).HasColumnName("PayStyle");
            this.Property(t => t.ATotal).HasColumnName("ATotal");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.paymoney).HasColumnName("paymoney");
        }
    }
}
