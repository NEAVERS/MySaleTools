using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_InvoiceOtherTotalDetailsMap : EntityTypeConfiguration<QP_InvoiceOtherTotalDetails>
    {
        public QP_InvoiceOtherTotalDetailsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.BillType, t.ID });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_InvoiceOtherTotalDetails");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.MainBillNumberID).HasColumnName("MainBillNumberID");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
        }
    }
}
