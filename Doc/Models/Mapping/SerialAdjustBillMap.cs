using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SerialAdjustBillMap : EntityTypeConfiguration<SerialAdjustBill>
    {
        public SerialAdjustBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.State });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Serial)
                .HasMaxLength(60);

            this.Property(t => t.OldSerial)
                .HasMaxLength(60);

            this.Property(t => t.KtypeID)
                .HasMaxLength(50);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID1)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID2)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("SerialAdjustBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.OldSerial).HasColumnName("OldSerial");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.BTypeID1).HasColumnName("BTypeID1");
            this.Property(t => t.BTypeID2).HasColumnName("BTypeID2");
            this.Property(t => t.InKtypeTime).HasColumnName("InKtypeTime");
            this.Property(t => t.OutKtypeTime).HasColumnName("OutKtypeTime");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.sameSearilID).HasColumnName("sameSearilID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
