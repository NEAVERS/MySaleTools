using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class gp_inoutPtypeSerialMap : EntityTypeConfiguration<gp_inoutPtypeSerial>
    {
        public gp_inoutPtypeSerialMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Serial, t.BillNumberid, t.ID });

            // Properties
            this.Property(t => t.Serial)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.BillNumberid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InKtypeID)
                .HasMaxLength(50);

            this.Property(t => t.OutKtyeID)
                .HasMaxLength(50);

            this.Property(t => t.IfCheck)
                .HasMaxLength(4);

            this.Property(t => t.BTypeID1)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID2)
                .HasMaxLength(50);

            this.Property(t => t.User)
                .HasMaxLength(256);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("gp_inoutPtypeSerial");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.BillNumberid).HasColumnName("BillNumberid");
            this.Property(t => t.InKtypeID).HasColumnName("InKtypeID");
            this.Property(t => t.OutKtyeID).HasColumnName("OutKtyeID");
            this.Property(t => t.IfCheck).HasColumnName("IfCheck");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.BTypeID1).HasColumnName("BTypeID1");
            this.Property(t => t.BTypeID2).HasColumnName("BTypeID2");
            this.Property(t => t.InKtypeTime).HasColumnName("InKtypeTime");
            this.Property(t => t.OutKtypeTime).HasColumnName("OutKtypeTime");
            this.Property(t => t.User).HasColumnName("User");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.PostTime).HasColumnName("PostTime");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
        }
    }
}
