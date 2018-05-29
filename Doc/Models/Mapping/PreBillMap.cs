using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PreBillMap : EntityTypeConfiguration<PreBill>
    {
        public PreBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillType, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.AtypeId)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PreBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.AtypeId).HasColumnName("AtypeId");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TeamNO1).HasColumnName("TeamNO1");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.ntotal).HasColumnName("ntotal");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.vipcardid).HasColumnName("vipcardid");
            this.Property(t => t.RelevanceBillId).HasColumnName("RelevanceBillId");
        }
    }
}
