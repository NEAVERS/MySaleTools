using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosVipCardsViewMap : EntityTypeConfiguration<PosVipCardsView>
    {
        public PosVipCardsViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CardId, t.CardtypeId, t.CardState, t.ISheadquarters, t.ConsumeAbility, t.doIntegral, t.NowDiscountTotal, t.LJXFJFJE, t.TotalSpendMoney, t.FillSite, t.Deleted, t.UpdateTag, t.iBYZD1, t.iBYZD2, t.nBYZD1, t.nBYZD2 });

            // Properties
            this.Property(t => t.CardId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CardNo)
                .HasMaxLength(50);

            this.Property(t => t.CardtypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardState)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.HolderName)
                .HasMaxLength(66);

            this.Property(t => t.HolderSex)
                .HasMaxLength(2);

            this.Property(t => t.HolderId)
                .HasMaxLength(26);

            this.Property(t => t.HolderTel)
                .HasMaxLength(50);

            this.Property(t => t.HolderTel2)
                .HasMaxLength(30);

            this.Property(t => t.HolderAdress)
                .HasMaxLength(50);

            this.Property(t => t.HandOutDept)
                .HasMaxLength(30);

            this.Property(t => t.Btypeid)
                .HasMaxLength(50);

            this.Property(t => t.CardPassWord)
                .HasMaxLength(10);

            this.Property(t => t.ISheadquarters)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperateID)
                .HasMaxLength(30);

            this.Property(t => t.ConsumeAbility)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.doIntegral)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NowDiscountTotal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LJXFJFJE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TotalSpendMoney)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FillSite)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.coment)
                .HasMaxLength(256);

            this.Property(t => t.Deleted)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UpdateTag)
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

            // Table & Column Mappings
            this.ToTable("PosVipCardsView");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.CardtypeId).HasColumnName("CardtypeId");
            this.Property(t => t.CardState).HasColumnName("CardState");
            this.Property(t => t.HolderName).HasColumnName("HolderName");
            this.Property(t => t.HolderSex).HasColumnName("HolderSex");
            this.Property(t => t.HolderId).HasColumnName("HolderId");
            this.Property(t => t.HolderTel).HasColumnName("HolderTel");
            this.Property(t => t.HolderTel2).HasColumnName("HolderTel2");
            this.Property(t => t.HolderAdress).HasColumnName("HolderAdress");
            this.Property(t => t.HandOutDept).HasColumnName("HandOutDept");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
            this.Property(t => t.Deposit).HasColumnName("Deposit");
            this.Property(t => t.HandOutDate).HasColumnName("HandOutDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.CardPassWord).HasColumnName("CardPassWord");
            this.Property(t => t.ISheadquarters).HasColumnName("ISheadquarters");
            this.Property(t => t.OperateID).HasColumnName("OperateID");
            this.Property(t => t.ConsumeAbility).HasColumnName("ConsumeAbility");
            this.Property(t => t.SaveMoney).HasColumnName("SaveMoney");
            this.Property(t => t.AllConsume).HasColumnName("AllConsume");
            this.Property(t => t.doIntegral).HasColumnName("doIntegral");
            this.Property(t => t.NowIntegral).HasColumnName("NowIntegral");
            this.Property(t => t.NowDiscountTotal).HasColumnName("NowDiscountTotal");
            this.Property(t => t.LJXFJFJE).HasColumnName("LJXFJFJE");
            this.Property(t => t.TotalFillMoney).HasColumnName("TotalFillMoney");
            this.Property(t => t.TotalSpendMoney).HasColumnName("TotalSpendMoney");
            this.Property(t => t.FillSite).HasColumnName("FillSite");
            this.Property(t => t.YearIniMoney).HasColumnName("YearIniMoney");
            this.Property(t => t.coment).HasColumnName("coment");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.UpdateTag).HasColumnName("UpdateTag");
            this.Property(t => t.cBYZD1).HasColumnName("cBYZD1");
            this.Property(t => t.cBYZD2).HasColumnName("cBYZD2");
            this.Property(t => t.iBYZD1).HasColumnName("iBYZD1");
            this.Property(t => t.iBYZD2).HasColumnName("iBYZD2");
            this.Property(t => t.nBYZD1).HasColumnName("nBYZD1");
            this.Property(t => t.nBYZD2).HasColumnName("nBYZD2");
        }
    }
}
