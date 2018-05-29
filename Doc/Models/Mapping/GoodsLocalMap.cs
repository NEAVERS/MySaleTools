using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class GoodsLocalMap : EntityTypeConfiguration<GoodsLocal>
    {
        public GoodsLocalMap()
        {
            // Primary Key
            this.HasKey(t => t.LTypeID);

            // Properties
            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.LTypeID)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.JobNumber)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GoodsLocal");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.LTypeID).HasColumnName("LTypeID");
            this.Property(t => t.JobNumber).HasColumnName("JobNumber");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.QTY).HasColumnName("QTY");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
        }
    }
}
