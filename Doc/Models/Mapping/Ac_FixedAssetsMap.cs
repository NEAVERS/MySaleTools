using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_FixedAssetsMap : EntityTypeConfiguration<Ac_FixedAssets>
    {
        public Ac_FixedAssetsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nId, t.STypeId, t.TypeId, t.ParId, t.Leveal, t.SonNum, t.SonCount, t.UserCode, t.FullName, t.Deleted, t.ATypeId, t.DepATypeId, t.DisATypeId });

            // Properties
            this.Property(t => t.nId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.STypeId)
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

            this.Property(t => t.Deleted)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ATypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DepATypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DisATypeId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_FixedAssets");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.ParId).HasColumnName("ParId");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.DepATypeId).HasColumnName("DepATypeId");
            this.Property(t => t.DisATypeId).HasColumnName("DisATypeId");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
        }
    }
}
