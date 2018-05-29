using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class gp_CruPtypeSerialMap : EntityTypeConfiguration<gp_CruPtypeSerial>
    {
        public gp_CruPtypeSerialMap()
        {
            // Primary Key
            this.HasKey(t => new { t.State, t.Flag });

            // Properties
            this.Property(t => t.Serial)
                .HasMaxLength(50);

            this.Property(t => t.KtypeID)
                .HasMaxLength(50);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID1)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID2)
                .HasMaxLength(50);

            this.Property(t => t.User)
                .HasMaxLength(256);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note)
                .HasMaxLength(256);

            this.Property(t => t.CommissionState)
                .HasMaxLength(1);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.LTypeID)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.Comment1)
                .HasMaxLength(256);

            this.Property(t => t.Comment2)
                .HasMaxLength(256);

            this.Property(t => t.Comment3)
                .HasMaxLength(256);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("gp_CruPtypeSerial");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.BTypeID1).HasColumnName("BTypeID1");
            this.Property(t => t.BTypeID2).HasColumnName("BTypeID2");
            this.Property(t => t.InKtypeTime).HasColumnName("InKtypeTime");
            this.Property(t => t.OutKtypeTime).HasColumnName("OutKtypeTime");
            this.Property(t => t.User).HasColumnName("User");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.CommissionState).HasColumnName("CommissionState");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.LTypeID).HasColumnName("LTypeID");
            this.Property(t => t.iniFlag).HasColumnName("iniFlag");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.Comment1).HasColumnName("Comment1");
            this.Property(t => t.Comment2).HasColumnName("Comment2");
            this.Property(t => t.Comment3).HasColumnName("Comment3");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
        }
    }
}
