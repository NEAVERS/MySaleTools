using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_AssetsCategoryMap : EntityTypeConfiguration<Ac_AssetsCategory>
    {
        public Ac_AssetsCategoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Deleted });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.StypeId)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(26);

            this.Property(t => t.FullName)
                .HasMaxLength(66);

            this.Property(t => t.Units)
                .HasMaxLength(200);

            this.Property(t => t.DepATypeId)
                .HasMaxLength(50);

            this.Property(t => t.ExpenseATypeId)
                .HasMaxLength(50);

            this.Property(t => t.AssertATypeId)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Ac_AssetsCategory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StypeId).HasColumnName("StypeId");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Units).HasColumnName("Units");
            this.Property(t => t.DepreciationMean).HasColumnName("DepreciationMean");
            this.Property(t => t.DurYear).HasColumnName("DurYear");
            this.Property(t => t.RemainsRate).HasColumnName("RemainsRate");
            this.Property(t => t.DepATypeId).HasColumnName("DepATypeId");
            this.Property(t => t.ExpenseATypeId).HasColumnName("ExpenseATypeId");
            this.Property(t => t.AssertATypeId).HasColumnName("AssertATypeId");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
