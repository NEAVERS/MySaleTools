using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class RequestIndexMap : EntityTypeConfiguration<RequestIndex>
    {
        public RequestIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillDate, t.BillCode, t.BillType });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.dtypeid)
                .HasMaxLength(50);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.checke)
                .HasMaxLength(50);

            this.Property(t => t.explain)
                .HasMaxLength(500);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.IfAudit)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("RequestIndex");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.dtypeid).HasColumnName("dtypeid");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.checke).HasColumnName("checke");
            this.Property(t => t.totalqty).HasColumnName("totalqty");
            this.Property(t => t.totalmoney).HasColumnName("totalmoney");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.tax).HasColumnName("tax");
            this.Property(t => t.IsIni).HasColumnName("IsIni");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.NTotalMoney).HasColumnName("NTotalMoney");
            this.Property(t => t.ifYearBill).HasColumnName("ifYearBill");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");
            this.Property(t => t.checkTime).HasColumnName("checkTime");
        }
    }
}
