using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class gp_initLendPtypeSerialMap : EntityTypeConfiguration<gp_initLendPtypeSerial>
    {
        public gp_initLendPtypeSerialMap()
        {
            // Primary Key
            this.HasKey(t => t.Serial);

            // Properties
            this.Property(t => t.Serial)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KtypeID)
                .HasMaxLength(50);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID1)
                .HasMaxLength(50);

            this.Property(t => t.BtypeID2)
                .HasMaxLength(50);

            this.Property(t => t.User)
                .HasMaxLength(256);

            this.Property(t => t.Note)
                .HasMaxLength(256);

            this.Property(t => t.CommissionState)
                .HasMaxLength(1);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.LTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("gp_initLendPtypeSerial");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.BTypeID1).HasColumnName("BTypeID1");
            this.Property(t => t.BtypeID2).HasColumnName("BtypeID2");
            this.Property(t => t.InKtypeTime).HasColumnName("InKtypeTime");
            this.Property(t => t.OutKTypeTime).HasColumnName("OutKTypeTime");
            this.Property(t => t.User).HasColumnName("User");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.CommissionState).HasColumnName("CommissionState");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.LTypeID).HasColumnName("LTypeID");
            this.Property(t => t.BFlag).HasColumnName("BFlag");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
        }
    }
}
