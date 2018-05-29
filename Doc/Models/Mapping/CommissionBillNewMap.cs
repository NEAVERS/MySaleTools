using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommissionBillNewMap : EntityTypeConfiguration<CommissionBillNew>
    {
        public CommissionBillNewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillCode, t.BillDate, t.CommissionSchemeID, t.Checke, t.Checker, t.CheckeTime, t.Explain, t.Comment, t.IsAuto, t.BillState, t.FChecker });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CommissionSchemeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Checke)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Checker)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Explain)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.IsAuto)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ifcheck)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.StypeID)
                .HasMaxLength(50);

            this.Property(t => t.Poster)
                .HasMaxLength(50);

            this.Property(t => t.FChecker)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FPoster)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommissionBillNew");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.CommissionStart).HasColumnName("CommissionStart");
            this.Property(t => t.CommissionEnd).HasColumnName("CommissionEnd");
            this.Property(t => t.CommissionSchemeID).HasColumnName("CommissionSchemeID");
            this.Property(t => t.CommissionType).HasColumnName("CommissionType");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Checker).HasColumnName("Checker");
            this.Property(t => t.CheckeTime).HasColumnName("CheckeTime");
            this.Property(t => t.CheckerTime).HasColumnName("CheckerTime");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsAuto).HasColumnName("IsAuto");
            this.Property(t => t.BillState).HasColumnName("BillState");
            this.Property(t => t.ifcheck).HasColumnName("ifcheck");
            this.Property(t => t.draft).HasColumnName("draft");
            this.Property(t => t.StypeID).HasColumnName("StypeID");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.Poster).HasColumnName("Poster");
            this.Property(t => t.PostTime).HasColumnName("PostTime");
            this.Property(t => t.CommissionTotal).HasColumnName("CommissionTotal");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.FChecker).HasColumnName("FChecker");
            this.Property(t => t.FCheckerTime).HasColumnName("FCheckerTime");
            this.Property(t => t.FPoster).HasColumnName("FPoster");
            this.Property(t => t.FPostTime).HasColumnName("FPostTime");
            this.Property(t => t.atid).HasColumnName("atid");
            this.Property(t => t.billtype).HasColumnName("billtype");
        }
    }
}
