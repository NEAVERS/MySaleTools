using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommonPosSaleListFreezeMap : EntityTypeConfiguration<CommonPosSaleListFreeze>
    {
        public CommonPosSaleListFreezeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PosVchCode, t.ListID, t.PtypeID, t.Qty, t.RetailPrice, t.DisCount, t.DisCountRate, t.Price, t.Sum, t.IsPresent, t.CXBillID, t.CXJFXS, t.IsUpSend, t.UpLoadPosVchCode, t.UniqueID, t.ListRow });

            // Properties
            this.Property(t => t.PosVchCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ListID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Qty)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RetailPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DisCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DisCountRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsPresent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CXBillID)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CXJFXS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsUpSend)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UpLoadPosVchCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UniqueID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ListRow)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommonPosSaleListFreeze");
            this.Property(t => t.PosVchCode).HasColumnName("PosVchCode");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.ColorID).HasColumnName("ColorID");
            this.Property(t => t.SizeID).HasColumnName("SizeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.DisCount).HasColumnName("DisCount");
            this.Property(t => t.DisCountRate).HasColumnName("DisCountRate");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Sum).HasColumnName("Sum");
            this.Property(t => t.IsPresent).HasColumnName("IsPresent");
            this.Property(t => t.CXBillID).HasColumnName("CXBillID");
            this.Property(t => t.CXJFXS).HasColumnName("CXJFXS");
            this.Property(t => t.IsUpSend).HasColumnName("IsUpSend");
            this.Property(t => t.UpLoadPosVchCode).HasColumnName("UpLoadPosVchCode");
            this.Property(t => t.UniqueID).HasColumnName("UniqueID");
            this.Property(t => t.ListRow).HasColumnName("ListRow");
        }
    }
}
