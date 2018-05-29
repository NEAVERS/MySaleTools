using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class STypeMap : EntityTypeConfiguration<SType>
    {
        public STypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.leveal, t.sonnum, t.soncount, t.FullName, t.Name, t.UserCode, t.Comment, t.deleted, t.IfAssetsIni, t.IsSelfVerify, t.Sid });

            // Properties
            this.Property(t => t.TypeId)
                .HasMaxLength(50);

            this.Property(t => t.parid)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.LinkMan)
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            this.Property(t => t.Tel)
                .HasMaxLength(100);

            this.Property(t => t.PostCode)
                .HasMaxLength(100);

            this.Property(t => t.TaxNo)
                .HasMaxLength(100);

            this.Property(t => t.Bank)
                .HasMaxLength(100);

            this.Property(t => t.Account)
                .HasMaxLength(100);

            this.Property(t => t.PyCode)
                .HasMaxLength(100);

            this.Property(t => t.BTypeID1)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID2)
                .HasMaxLength(50);

            this.Property(t => t.ATypeID)
                .HasMaxLength(50);

            this.Property(t => t.ATypeID2)
                .HasMaxLength(50);

            this.Property(t => t.IfAssetsIni)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ATypeID3)
                .HasMaxLength(50);

            this.Property(t => t.IsSelfVerify)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VerifyID)
                .HasMaxLength(50);

            this.Property(t => t.ATypeID4)
                .HasMaxLength(50);

            this.Property(t => t.calcFullName)
                .HasMaxLength(100);

            this.Property(t => t.Sid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("SType");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.parid).HasColumnName("parid");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.LinkMan).HasColumnName("LinkMan");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.PostCode).HasColumnName("PostCode");
            this.Property(t => t.TaxNo).HasColumnName("TaxNo");
            this.Property(t => t.Bank).HasColumnName("Bank");
            this.Property(t => t.Account).HasColumnName("Account");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.BTypeID1).HasColumnName("BTypeID1");
            this.Property(t => t.BTypeID2).HasColumnName("BTypeID2");
            this.Property(t => t.PriceType).HasColumnName("PriceType");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.ATypeID2).HasColumnName("ATypeID2");
            this.Property(t => t.IfAssetsIni).HasColumnName("IfAssetsIni");
            this.Property(t => t.IsUpLoad).HasColumnName("IsUpLoad");
            this.Property(t => t.ATypeID3).HasColumnName("ATypeID3");
            this.Property(t => t.IsSelfVerify).HasColumnName("IsSelfVerify");
            this.Property(t => t.VerifyID).HasColumnName("VerifyID");
            this.Property(t => t.ATypeID4).HasColumnName("ATypeID4");
            this.Property(t => t.calcFullName).HasColumnName("calcFullName");
            this.Property(t => t.Sid).HasColumnName("Sid");
        }
    }
}
