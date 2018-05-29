using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class nVipCardSetMap : EntityTypeConfiguration<nVipCardSet>
    {
        public nVipCardSetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VipCardTypeID, t.TypeName, t.ifJF, t.deleted, t.IfBirthDay, t.IfDate });

            // Properties
            this.Property(t => t.VipCardTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TypeName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.DiscountType)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ifJF)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.deleted)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Comment)
                .HasMaxLength(600);

            this.Property(t => t.IfBirthDay)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.BirthDayMultiple)
                .HasMaxLength(10);

            this.Property(t => t.IfDate)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DateMultiple)
                .HasMaxLength(10);

            this.Property(t => t.StartDate)
                .HasMaxLength(50);

            this.Property(t => t.EndDate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nVipCardSet");
            this.Property(t => t.VipCardTypeID).HasColumnName("VipCardTypeID");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.DiscountType).HasColumnName("DiscountType");
            this.Property(t => t.ifJF).HasColumnName("ifJF");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.VipCardnum).HasColumnName("VipCardnum");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.ValidType).HasColumnName("ValidType");
            this.Property(t => t.CardTypeDiscount).HasColumnName("CardTypeDiscount");
            this.Property(t => t.jfgz).HasColumnName("jfgz");
            this.Property(t => t.GiveCent).HasColumnName("GiveCent");
            this.Property(t => t.TypeLevel).HasColumnName("TypeLevel");
            this.Property(t => t.StandardCent).HasColumnName("StandardCent");
            this.Property(t => t.DeductCent).HasColumnName("DeductCent");
            this.Property(t => t.IfBirthDay).HasColumnName("IfBirthDay");
            this.Property(t => t.BirthDayMultiple).HasColumnName("BirthDayMultiple");
            this.Property(t => t.IfDate).HasColumnName("IfDate");
            this.Property(t => t.DateMultiple).HasColumnName("DateMultiple");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.IfSalesIntegral).HasColumnName("IfSalesIntegral");
        }
    }
}
