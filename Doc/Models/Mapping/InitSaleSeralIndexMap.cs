using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class InitSaleSeralIndexMap : EntityTypeConfiguration<InitSaleSeralIndex>
    {
        public InitSaleSeralIndexMap()
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

            this.Property(t => t.checke)
                .HasMaxLength(50);

            this.Property(t => t.explain)
                .HasMaxLength(500);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InitSaleSeralIndex");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.checke).HasColumnName("checke");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.IsIni).HasColumnName("IsIni");
        }
    }
}
