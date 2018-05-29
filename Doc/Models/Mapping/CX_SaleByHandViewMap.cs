using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CX_SaleByHandViewMap : EntityTypeConfiguration<CX_SaleByHandView>
    {
        public CX_SaleByHandViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.SaleType });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SaleType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.MoneyTicket)
                .HasMaxLength(1);

            this.Property(t => t.GoodsPro)
                .HasMaxLength(1);

            this.Property(t => t.ChoosePro)
                .HasMaxLength(100);

            this.Property(t => t.TotalMoney)
                .HasMaxLength(20);

            this.Property(t => t.TotalQty)
                .HasMaxLength(20);

            this.Property(t => t.Discount)
                .HasMaxLength(10);

            this.Property(t => t.RebateMoney)
                .HasMaxLength(20);

            this.Property(t => t.MoneyAdd)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CX_SaleByHandView");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.SaleType).HasColumnName("SaleType");
            this.Property(t => t.MoneyTicket).HasColumnName("MoneyTicket");
            this.Property(t => t.GoodsPro).HasColumnName("GoodsPro");
            this.Property(t => t.ChoosePro).HasColumnName("ChoosePro");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.TotalQty).HasColumnName("TotalQty");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.RebateMoney).HasColumnName("RebateMoney");
            this.Property(t => t.MoneyAdd).HasColumnName("MoneyAdd");
        }
    }
}
