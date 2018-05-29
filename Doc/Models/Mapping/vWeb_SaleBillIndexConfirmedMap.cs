using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_SaleBillIndexConfirmedMap : EntityTypeConfiguration<vWeb_SaleBillIndexConfirmed>
    {
        public vWeb_SaleBillIndexConfirmedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillDate, t.BillCode, t.shdw, t.jsr });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.shdw)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.shdwID)
                .HasMaxLength(50);

            this.Property(t => t.jsr)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.DTypeId)
                .HasMaxLength(50);

            this.Property(t => t.StockOut)
                .HasMaxLength(66);

            this.Property(t => t.StockIn)
                .HasMaxLength(66);

            // Table & Column Mappings
            this.ToTable("vWeb_SaleBillIndexConfirmed");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.shdw).HasColumnName("shdw");
            this.Property(t => t.shdwID).HasColumnName("shdwID");
            this.Property(t => t.jsr).HasColumnName("jsr");
            this.Property(t => t.totalmoney).HasColumnName("totalmoney");
            this.Property(t => t.totalqty).HasColumnName("totalqty");
            this.Property(t => t.tax).HasColumnName("tax");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.DTypeId).HasColumnName("DTypeId");
            this.Property(t => t.StockOut).HasColumnName("StockOut");
            this.Property(t => t.StockIn).HasColumnName("StockIn");
        }
    }
}
