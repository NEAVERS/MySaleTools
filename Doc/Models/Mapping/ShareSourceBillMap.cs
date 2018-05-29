using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ShareSourceBillMap : EntityTypeConfiguration<ShareSourceBill>
    {
        public ShareSourceBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillType, t.FromBillNumberID, t.FromBillID, t.FromBillType, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FromBillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FromBillID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FromBillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ShareSourceBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.FromBillNumberID).HasColumnName("FromBillNumberID");
            this.Property(t => t.FromBillID).HasColumnName("FromBillID");
            this.Property(t => t.FromBillType).HasColumnName("FromBillType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ShareFee).HasColumnName("ShareFee");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
