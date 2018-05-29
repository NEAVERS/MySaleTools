using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_Bill_CashMoneyItemsMap : EntityTypeConfiguration<Ac_Voucher_Bill_CashMoneyItems>
    {
        public Ac_Voucher_Bill_CashMoneyItemsMap()
        {
            // Primary Key
            this.HasKey(t => t.nId);

            // Properties
            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.MATypeId)
                .HasMaxLength(50);

            this.Property(t => t.DATypeId)
                .HasMaxLength(50);

            this.Property(t => t.FYear)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Bill_CashMoneyItems");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.MATypeId).HasColumnName("MATypeId");
            this.Property(t => t.DATypeId).HasColumnName("DATypeId");
            this.Property(t => t.FDc).HasColumnName("FDc");
            this.Property(t => t.FAdc).HasColumnName("FAdc");
            this.Property(t => t.RowNo).HasColumnName("RowNo");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.TotalFor).HasColumnName("TotalFor");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
        }
    }
}
