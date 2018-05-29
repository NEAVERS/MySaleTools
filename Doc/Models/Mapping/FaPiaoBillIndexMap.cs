using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FaPiaoBillIndexMap : EntityTypeConfiguration<FaPiaoBillIndex>
    {
        public FaPiaoBillIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.BillDate, t.BillCode, t.BillType });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FaPiaoType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.FaPiaoCode)
                .HasMaxLength(256);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.Explain)
                .HasMaxLength(256);

            this.Property(t => t.BTypeID)
                .HasMaxLength(100);

            this.Property(t => t.ETypeID)
                .HasMaxLength(100);

            this.Property(t => t.DTypeID)
                .HasMaxLength(100);

            this.Property(t => t.checke)
                .HasMaxLength(100);

            this.Property(t => t.Assessor)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.DealBTypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FaPiaoBillIndex");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.FaPiaoType).HasColumnName("FaPiaoType");
            this.Property(t => t.FaPiaoCode).HasColumnName("FaPiaoCode");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.DTypeID).HasColumnName("DTypeID");
            this.Property(t => t.checke).HasColumnName("checke");
            this.Property(t => t.Assessor).HasColumnName("Assessor");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.TotalQty).HasColumnName("TotalQty");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.TaxTotalMoney).HasColumnName("TaxTotalMoney");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.OtherTotal).HasColumnName("OtherTotal");
            this.Property(t => t.ifYearBill).HasColumnName("ifYearBill");
            this.Property(t => t.IsIni).HasColumnName("IsIni");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.NTotalMoney).HasColumnName("NTotalMoney");
            this.Property(t => t.NTaxTotalMoney).HasColumnName("NTaxTotalMoney");
            this.Property(t => t.DealBTypeID).HasColumnName("DealBTypeID");
            this.Property(t => t.TaskType).HasColumnName("TaskType");
        }
    }
}
