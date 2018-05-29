using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommissionBillNewDetailMap : EntityTypeConfiguration<CommissionBillNewDetail>
    {
        public CommissionBillNewDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EtypeID)
                .HasMaxLength(50);

            this.Property(t => t.DtypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("CommissionBillNewDetail");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.DtypeID).HasColumnName("DtypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CommissionTotal).HasColumnName("CommissionTotal");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
