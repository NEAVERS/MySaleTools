using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class StockCheckIndexMap : EntityTypeConfiguration<StockCheckIndex>
    {
        public StockCheckIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.StockCheckID, t.BillDate, t.BillCode, t.StockQtyEndDate });

            // Properties
            this.Property(t => t.StockCheckID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("StockCheckIndex");
            this.Property(t => t.StockCheckID).HasColumnName("StockCheckID");
            this.Property(t => t.Pass).HasColumnName("Pass");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ifWX).HasColumnName("ifWX");
            this.Property(t => t.StockQtyEndDate).HasColumnName("StockQtyEndDate");
        }
    }
}
