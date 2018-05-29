using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosRetailCashMap : EntityTypeConfiguration<PosRetailCash>
    {
        public PosRetailCashMap()
        {
            // Primary Key
            this.HasKey(t => t.Stypeid);

            // Properties
            this.Property(t => t.Stypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CashAtypeid)
                .HasMaxLength(50);

            this.Property(t => t.BankAtypeid)
                .HasMaxLength(50);

            this.Property(t => t.YSAtypeid)
                .HasMaxLength(50);

            this.Property(t => t.StoreCardAtypeid)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("PosRetailCash");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.CashAtypeid).HasColumnName("CashAtypeid");
            this.Property(t => t.BankAtypeid).HasColumnName("BankAtypeid");
            this.Property(t => t.YSAtypeid).HasColumnName("YSAtypeid");
            this.Property(t => t.StoreCardAtypeid).HasColumnName("StoreCardAtypeid");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
