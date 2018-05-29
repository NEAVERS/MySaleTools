using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_InsuranceBill_PTypeMap : EntityTypeConfiguration<QP_InsuranceBill_PType>
    {
        public QP_InsuranceBill_PTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.PTypeID, t.Virtual, t.IsUnit2 });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Virtual)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_InsuranceBill_PType");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.InsuranceTotal).HasColumnName("InsuranceTotal");
            this.Property(t => t.GoodsCostTotal).HasColumnName("GoodsCostTotal");
            this.Property(t => t.Virtual).HasColumnName("Virtual");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.QuickOrReceptionBillId).HasColumnName("QuickOrReceptionBillId");
        }
    }
}
