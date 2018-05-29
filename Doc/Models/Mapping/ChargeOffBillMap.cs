using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ChargeOffBillMap : EntityTypeConfiguration<ChargeOffBill>
    {
        public ChargeOffBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.FromBillNumberid, t.FromBillType, t.ID, t.ChargeOffType, t.IsCharged, t.BTypeID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FromBillNumberid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FromBillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ChargeOffType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("ChargeOffBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.FromBillNumberid).HasColumnName("FromBillNumberid");
            this.Property(t => t.FromBillType).HasColumnName("FromBillType");
            this.Property(t => t.FromBillID).HasColumnName("FromBillID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ChargeOffType).HasColumnName("ChargeOffType");
            this.Property(t => t.IsCharged).HasColumnName("IsCharged");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.ChargeOffValue).HasColumnName("ChargeOffValue");
            this.Property(t => t.NChargeOffValue).HasColumnName("NChargeOffValue");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
