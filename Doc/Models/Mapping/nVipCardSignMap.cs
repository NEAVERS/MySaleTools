using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class nVipCardSignMap : EntityTypeConfiguration<nVipCardSign>
    {
        public nVipCardSignMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VipCardID, t.VipCardTypeID, t.deleted });

            // Properties
            this.Property(t => t.VipCardID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.VipCardCode)
                .HasMaxLength(50);

            this.Property(t => t.VipCardTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Bname)
                .HasMaxLength(66);

            this.Property(t => t.Bsex)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Btel)
                .HasMaxLength(50);

            this.Property(t => t.Baddr)
                .HasMaxLength(50);

            this.Property(t => t.Bpostcode)
                .HasMaxLength(200);

            this.Property(t => t.Btrade)
                .HasMaxLength(12);

            this.Property(t => t.BIDcard)
                .HasMaxLength(26);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.deleted)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.IsCz)
                .HasMaxLength(2);

            this.Property(t => t.pWord)
                .HasMaxLength(10);

            this.Property(t => t.RATypeID)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID)
                .HasMaxLength(50);

            this.Property(t => t.IsWashTimes)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PyCode)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("nVipCardSign");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.VipCardCode).HasColumnName("VipCardCode");
            this.Property(t => t.VipCardTypeID).HasColumnName("VipCardTypeID");
            this.Property(t => t.Bname).HasColumnName("Bname");
            this.Property(t => t.Bsex).HasColumnName("Bsex");
            this.Property(t => t.Bbirthday).HasColumnName("Bbirthday");
            this.Property(t => t.Btel).HasColumnName("Btel");
            this.Property(t => t.Baddr).HasColumnName("Baddr");
            this.Property(t => t.Bpostcode).HasColumnName("Bpostcode");
            this.Property(t => t.Btrade).HasColumnName("Btrade");
            this.Property(t => t.BIDcard).HasColumnName("BIDcard");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.BeginMoney).HasColumnName("BeginMoney");
            this.Property(t => t.BeginCent).HasColumnName("BeginCent");
            this.Property(t => t.totalMoney).HasColumnName("totalMoney");
            this.Property(t => t.totalCent).HasColumnName("totalCent");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.qCczMoney).HasColumnName("qCczMoney");
            this.Property(t => t.lJczMoney).HasColumnName("lJczMoney");
            this.Property(t => t.xFczMoney).HasColumnName("xFczMoney");
            this.Property(t => t.cZyeMoney).HasColumnName("cZyeMoney");
            this.Property(t => t.IsCz).HasColumnName("IsCz");
            this.Property(t => t.pWord).HasColumnName("pWord");
            this.Property(t => t.RATypeID).HasColumnName("RATypeID");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.CarType).HasColumnName("CarType");
            this.Property(t => t.CarWashPrice).HasColumnName("CarWashPrice");
            this.Property(t => t.IsWashTimes).HasColumnName("IsWashTimes");
            this.Property(t => t.CanWashTimes00).HasColumnName("CanWashTimes00");
            this.Property(t => t.CanWashTimes).HasColumnName("CanWashTimes");
            this.Property(t => t.CanWashTimesTotal).HasColumnName("CanWashTimesTotal");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
        }
    }
}
