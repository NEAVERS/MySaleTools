using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosvipcardtypesViewMap : EntityTypeConfiguration<PosvipcardtypesView>
    {
        public PosvipcardtypesViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CardTypeId, t.CardTypeName, t.LimitTotal, t.IntegralMod, t.IsMoney, t.NeedPass, t.isStop, t.type, t.iBYZD1, t.iBYZD2, t.nBYZD1, t.nBYZD2, t.IsAllowAdd });

            // Properties
            this.Property(t => t.CardTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CardTypeName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.LimitTotal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IntegralMod)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperateId)
                .HasMaxLength(30);

            this.Property(t => t.DiscountType)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.PriceTypeId)
                .HasMaxLength(30);

            this.Property(t => t.IsMoney)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NeedPass)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.isStop)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cBYZD1)
                .HasMaxLength(30);

            this.Property(t => t.cBYZD2)
                .HasMaxLength(30);

            this.Property(t => t.iBYZD1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.iBYZD2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nBYZD1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nBYZD2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BranchID)
                .HasMaxLength(30);

            this.Property(t => t.IsAllowAdd)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosvipcardtypesView");
            this.Property(t => t.CardTypeId).HasColumnName("CardTypeId");
            this.Property(t => t.CardTypeName).HasColumnName("CardTypeName");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.LimitTotal).HasColumnName("LimitTotal");
            this.Property(t => t.IntegralMod).HasColumnName("IntegralMod");
            this.Property(t => t.OperateId).HasColumnName("OperateId");
            this.Property(t => t.DiscountType).HasColumnName("DiscountType");
            this.Property(t => t.PriceTypeId).HasColumnName("PriceTypeId");
            this.Property(t => t.IsMoney).HasColumnName("IsMoney");
            this.Property(t => t.NeedPass).HasColumnName("NeedPass");
            this.Property(t => t.isStop).HasColumnName("isStop");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.cBYZD1).HasColumnName("cBYZD1");
            this.Property(t => t.cBYZD2).HasColumnName("cBYZD2");
            this.Property(t => t.iBYZD1).HasColumnName("iBYZD1");
            this.Property(t => t.iBYZD2).HasColumnName("iBYZD2");
            this.Property(t => t.nBYZD1).HasColumnName("nBYZD1");
            this.Property(t => t.nBYZD2).HasColumnName("nBYZD2");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.IsAllowAdd).HasColumnName("IsAllowAdd");
        }
    }
}
