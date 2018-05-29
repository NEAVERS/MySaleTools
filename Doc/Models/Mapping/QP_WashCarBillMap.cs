using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_WashCarBillMap : EntityTypeConfiguration<QP_WashCarBill>
    {
        public QP_WashCarBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.etypeid });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_WashCarBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
        }
    }
}
