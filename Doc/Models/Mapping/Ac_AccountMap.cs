using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_AccountMap : EntityTypeConfiguration<Ac_Account>
    {
        public Ac_AccountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.StypeId, t.TypeId, t.ParId, t.Leveal, t.SonNum, t.SonCount, t.UserCode, t.FullName, t.ETypeId, t.CreateDateTime, t.FLeveal, t.Deleted, t.XiWaMaxNumber, t.IsOther, t.KeyId });

            // Properties
            this.Property(t => t.StypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ParId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(400);

            this.Property(t => t.PyCode)
                .HasMaxLength(200);

            this.Property(t => t.ETypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MainItems)
                .HasMaxLength(100);

            this.Property(t => t.AdditionItems)
                .HasMaxLength(100);

            this.Property(t => t.AscIds)
                .HasMaxLength(200);

            this.Property(t => t.FLeveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Deleted)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.XiWaMaxNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsOther)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KeyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Group)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Ac_Account");
            this.Property(t => t.StypeId).HasColumnName("StypeId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.ParId).HasColumnName("ParId");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Fdc).HasColumnName("Fdc");
            this.Property(t => t.IsCash).HasColumnName("IsCash");
            this.Property(t => t.IsBank).HasColumnName("IsBank");
            this.Property(t => t.IsDiary).HasColumnName("IsDiary");
            this.Property(t => t.IsPreGather).HasColumnName("IsPreGather");
            this.Property(t => t.IsPrePay).HasColumnName("IsPrePay");
            this.Property(t => t.IsGather).HasColumnName("IsGather");
            this.Property(t => t.IsPay).HasColumnName("IsPay");
            this.Property(t => t.IsVip).HasColumnName("IsVip");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.CreateDateTime).HasColumnName("CreateDateTime");
            this.Property(t => t.MainItems).HasColumnName("MainItems");
            this.Property(t => t.AdditionItems).HasColumnName("AdditionItems");
            this.Property(t => t.ExchId).HasColumnName("ExchId");
            this.Property(t => t.FAcctint).HasColumnName("FAcctint");
            this.Property(t => t.FAcnt).HasColumnName("FAcnt");
            this.Property(t => t.AscIds).HasColumnName("AscIds");
            this.Property(t => t.FAdjustRate).HasColumnName("FAdjustRate");
            this.Property(t => t.FContact).HasColumnName("FContact");
            this.Property(t => t.FInterest).HasColumnName("FInterest");
            this.Property(t => t.FintRate).HasColumnName("FintRate");
            this.Property(t => t.FLeveal).HasColumnName("FLeveal");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.IsOther).HasColumnName("IsOther");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.IsDist).HasColumnName("IsDist");
            this.Property(t => t.KeyId).HasColumnName("KeyId");
            this.Property(t => t.Group).HasColumnName("Group");
            this.Property(t => t.CheckType).HasColumnName("CheckType");
        }
    }
}
