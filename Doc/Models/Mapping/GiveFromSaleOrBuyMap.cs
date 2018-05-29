using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class GiveFromSaleOrBuyMap : EntityTypeConfiguration<GiveFromSaleOrBuy>
    {
        public GiveFromSaleOrBuyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IfCheck)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID)
                .HasMaxLength(50);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Explain)
                .HasMaxLength(256);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("GiveFromSaleOrBuy");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SourceBillNumberId).HasColumnName("SourceBillNumberId");
            this.Property(t => t.DestBillNumberId).HasColumnName("DestBillNumberId");
            this.Property(t => t.IfCheck).HasColumnName("IfCheck");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
